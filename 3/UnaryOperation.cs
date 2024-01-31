using System;
using System.Collections.Generic;
using System.Text;

namespace пз3
{
    public abstract class UnaryOperation : Expr
    {
        public Expr Operand { get; }
        public override IEnumerable<string> Variables => Operand.Variables;
        public override bool IsConstant => Operand.IsConstant;
        public override bool IsPolynom => Operand.IsPolynom;
        public UnaryOperation(Expr operand)
        {
            this.Operand = operand;
        }
    }
    // Унарный плюс
    public class UnaryPlus : UnaryOperation
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Operand.Compute(variableValues);
        public override Expr Diff() => Operand.Diff();
        public UnaryPlus(Expr Operand) : base(Operand) { }
        public override string ToString() => $"+{Operand}";
    }

    // Унарный минус
    public class UnaryMinus : UnaryOperation
    {
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => -Operand.Compute(variableValues);
        public override Expr Diff() => -Operand.Diff();
        public UnaryMinus(Expr Operand) : base(Operand) { }
        public override string ToString() => $"-{Operand}";
    }
}
