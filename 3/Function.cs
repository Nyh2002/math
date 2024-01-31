using System;
using System.Collections.Generic;
using System.Text;
using static пз3.GroupFunction;

namespace пз3
{
    public abstract class Function : Expr
    {
        protected Expr Argument { get; }
        public override bool IsConstant => Argument.IsConstant;
        public override bool IsPolynom => Argument.IsConstant;
        public override IEnumerable<string> Variables => Argument.Variables;
        protected Function(Expr argument)
        {
            this.Argument = argument;
        }
    }
    // обратные гиперболическим функции
    // ареасинус
    public class Arsh : Function
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double arg = Argument.Compute(variableValues);
            return Math.Log(arg + Math.Sqrt(arg * arg + 1));
            //return Math.Asinh(arg);
        }
        public Arsh(Expr Argument) : base(Argument) { }
        public override Expr Diff() => (1 / Sqrt(Argument * Argument + 1)) * Argument.Diff();
        public override string ToString() => $"Arsh({Argument})";
    }
    // ареакосинус
    public class Arch : Function
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double arg = Argument.Compute(variableValues);
            //return Math.Acosh(arg);
            if (arg < 1) throw new Exception("Не из области определения");
            else return Math.Log(arg + Math.Sqrt(arg * arg - 1));
        }
        public override Expr Diff() => (1 / Sqrt(Argument * Argument - 1)) * Argument.Diff();
        public Arch(Expr Argument) : base(Argument) { }
        public override string ToString() => $"Arch({Argument})";
    }
    // ареатангенс
    public class Arth : Function
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double arg = Argument.Compute(variableValues);
            //return Math.Atanh(arg);
            if ((arg <= -1) ^ (arg == 0) ^ (arg >= 1)) throw new Exception("Не из области определения");
            return 0.5 * Math.Log((1 + arg) / (1 - arg));
        }
        public override Expr Diff() => (1 / (1 - Argument * Argument)) * Argument.Diff();
        public Arth(Expr Argument) : base(Argument) { }
        public override string ToString() => $"Arth({Argument})";
    }
    // ареакотангенс
    public class Arcth : Function
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double arg = Argument.Compute(variableValues);
            if ((arg >= -1) & (arg <= 1)) throw new Exception("Не из области определения");
            return 0.5 * Math.Log((1 + arg) / (arg - 1));
        }
        public override Expr Diff() => (1 / (1 - Argument * Argument)) * Argument.Diff();
        public Arcth(Expr Argument) : base(Argument) { }
        public override string ToString() => $"Arcth({Argument})";
    }
    // ареасеканс
    public class Arsch : Function
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double arg = Argument.Compute(variableValues);
            if ((arg <= 0) ^ (arg > 1)) throw new Exception("Не из области определения");
            return Math.Log(1 / arg + Math.Sqrt(1 / (arg * arg) - 1));
        }
        public override Expr Diff() => -(1 / (Argument * (Argument + 1) * Sqrt((Argument - 1) / (Argument + 1)))) * Argument.Diff();
        public Arsch(Expr Argument) : base(Argument) { }
        public override string ToString() => $"Arsch({Argument})";
    }
    // ареакосеканс
    public class Arcsch : Function
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double arg = Argument.Compute(variableValues);
            if (arg == 0) throw new Exception("Не из области определения");
            return Math.Log(1 / arg + Math.Sqrt(1 / (arg * arg) + 1));
        }
        public override Expr Diff() => -(1 / (Argument * (Argument + 1) * Sqrt(1 + (1 / (Argument * Argument))))) * Argument.Diff();
        public Arcsch(Expr Argument) : base(Argument) { }
        public override string ToString() => $"Arcsch({Argument})";
    }

    public class GroupFunction
    {
        public static Arsh Arsh(Expr arg) => new Arsh(arg);
        public static Arch Arch(Expr arg) => new Arch(arg);
        public static Arth Arth(Expr arg) => new Arth(arg);
        public static Arcth Arcth(Expr arg) => new Arcth(arg);
        public static Arsch Arsch(Expr arg) => new Arsch(arg);
        public static Arcsch Arcsch(Expr arg) => new Arcsch(arg);
        public static Sqrt Sqrt(Expr arg) => new Sqrt(arg); // для поиска производных гиперболических функций

        public static Expr Diff(Expr function) => function.Diff();
    }

    public class Sqrt : Function
    {
        public Sqrt(Expr Argument) : base(Argument) { }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Math.Sqrt(Argument.Compute(variableValues));
        public override Expr Diff() => 1 / (2 * new Sqrt(Argument)) * Argument.Diff();
        public override string ToString() => $" Sqrt({Argument})";
    }
}

