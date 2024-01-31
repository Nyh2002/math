using System;
using System.Collections;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using пз3;

namespace пз3
{
    public class Variable : Expr
    {
        public string Var { get; }
        public override IEnumerable<string> Variables => new string[] { Var };
        public override bool IsConstant => false;
        public override bool IsPolynom => true;
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => variableValues[Var];

        public override Expr Diff() => 1;
        public Variable(string var)
        {
            this.Var = var;
        }
        public override string ToString() => Var;
    }
    public class Constant : Expr
    {
        public double Const { get; }
        public override IEnumerable<string> Variables => Enumerable.Empty<string>();
        public override bool IsConstant => true;
        public override bool IsPolynom => true;
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Const;
        public override Expr Diff() => 0;
        public Constant(double const1)
        {
            this.Const = const1;
        }
        public override string ToString() => Const.ToString();
    }

    public abstract class Expr : IExpr
    {
        public abstract double Compute(IReadOnlyDictionary<string, double> variableValues = null);
        public abstract IEnumerable<string> Variables { get; }
        public abstract bool IsConstant { get; }
        public abstract bool IsPolynom { get; }
        public abstract Expr Diff();

        public static Expr operator +(Expr operand) => new UnaryPlus(operand);
        public static Expr operator -(Expr operand) => new UnaryMinus(operand);

        public static Expr operator +(Expr left_operand, Expr right_operand) => new Addition(left_operand, right_operand);
        public static Expr operator -(Expr left_operand, Expr right_operand) => new Subtraction(left_operand, right_operand);
        public static Expr operator *(Expr left_operand, Expr right_operand) => new Multiplication(left_operand, right_operand);
        public static Expr operator /(Expr left_operand, Expr right_operand) => new Division(left_operand, right_operand);
        public static Expr operator %(Expr left_operand, Expr right_operand) => new Remainder_of_division(left_operand, right_operand);

        public static implicit operator Expr(double arg) => new Constant(arg);

    }

}