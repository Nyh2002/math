using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace пз3
{
    public abstract class BinaryOperation : Expr
    {
        public Expr LeftOperand { get; }
        public Expr RightOperand { get; }
        public override IEnumerable<string> Variables => LeftOperand.Variables.Union(RightOperand.Variables);
        public override bool IsConstant => LeftOperand.IsConstant && RightOperand.IsConstant;
        public BinaryOperation(Expr left_operand, Expr right_operand)
        {
            this.LeftOperand = left_operand;
            this.RightOperand = right_operand;
        }
    }
    // Сложение
    public class Addition : BinaryOperation
    {
        public override bool IsPolynom => LeftOperand.IsPolynom && RightOperand.IsPolynom;
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => LeftOperand.Compute(variableValues) + RightOperand.Compute(variableValues);
        public override Expr Diff() => LeftOperand.Diff() + RightOperand.Diff();
        public Addition(Expr LeftOperand, Expr RightOperand) : base(LeftOperand, RightOperand) { }
        public override string ToString() => RightOperand is UnaryMinus ? $"({LeftOperand} + ({RightOperand}))" : $"({LeftOperand} + {RightOperand})";
    }

    // Вычитание
    public class Subtraction : BinaryOperation
    {
        public override bool IsPolynom => LeftOperand.IsPolynom && RightOperand.IsPolynom;
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => LeftOperand.Compute(variableValues) - RightOperand.Compute(variableValues);
        public override Expr Diff() => LeftOperand.Diff() - RightOperand.Diff();
        public Subtraction(Expr LeftOperand, Expr RightOperand) : base(LeftOperand, RightOperand) { }
        public override string ToString() => RightOperand is UnaryMinus ? $"({LeftOperand} - ({RightOperand}))" : $"({LeftOperand} - {RightOperand})";
    }

    // Умножение
    public class Multiplication : BinaryOperation
    {
        public override bool IsPolynom => LeftOperand.IsPolynom && RightOperand.IsPolynom;
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => LeftOperand.Compute(variableValues) * RightOperand.Compute(variableValues);
        public override Expr Diff() => LeftOperand.Diff()* RightOperand + RightOperand.Diff()* LeftOperand;
        public Multiplication(Expr LeftOperand, Expr RightOperand) : base(LeftOperand, RightOperand) { }
        public override string ToString() => RightOperand is UnaryMinus ? $"({LeftOperand} * ({RightOperand}))" : $"({LeftOperand} * {RightOperand})";
    }

    // Деление
    public class Division : BinaryOperation
    {
        public override bool IsPolynom => LeftOperand.IsPolynom && RightOperand.IsConstant;
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            if (RightOperand.Compute(variableValues) == 0) throw new Exception("Делить на 0 нельзя");
            return LeftOperand.Compute(variableValues) / RightOperand.Compute(variableValues);
        }
        public override Expr Diff() => (LeftOperand.Diff() * RightOperand - RightOperand.Diff() * LeftOperand)/ (RightOperand * RightOperand);
        public Division(Expr LeftOperand, Expr RightOperand) : base(LeftOperand, RightOperand) { }
        public override string ToString() => RightOperand is UnaryMinus ? $"({LeftOperand} / ({RightOperand}))" : $"({LeftOperand} / {RightOperand})";
    }
    // Остаток от деления
    public class Remainder_of_division : BinaryOperation
    {
        public override bool IsPolynom => LeftOperand.IsPolynom && RightOperand.IsPolynom;
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => LeftOperand.Compute(variableValues) % RightOperand.Compute(variableValues);
        public override Expr Diff() => throw new Exception("Производной у остатка деления нет");
        public Remainder_of_division(Expr LeftOperand, Expr RightOperand) : base(LeftOperand, RightOperand) { }
        public override string ToString() => RightOperand is UnaryMinus ? $"({LeftOperand} % ({RightOperand}))" : $"({LeftOperand} % {RightOperand})";
    }

}
