using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using пз3;
using static пз3.GroupFunction;

namespace UnitTest
{

    [TestClass]
    public class DiffTest
    {
        [TestClass]
        public class DiffUnaryOperation
        {
            [TestMethod]
            public void DiffUnaryPlus()
            {
                var a = new Variable("a");
                var expr = Diff(+a);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5 }), 1);
            }

            [TestMethod]
            public void DiffUnaryMinus()
            {
                var a = new Variable("a");
                var expr = Diff(-a);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5 }), -1);
            }
        }

        [TestClass]
        public class DiffBinaryOperation
        {
            [TestMethod]
            public void DiffAdittion()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = Diff(a + b);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 2);
            }

            [TestMethod]
            public void DiffSubtraction()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = Diff(a - b);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 0);
            }

            [TestMethod]
            public void DiffMultiplication()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = Diff(a * b);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 8);
            }


            [TestMethod]
            public void DiffDivision()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = Diff(a * b);
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), -0, 08);
            }

            [TestMethod]
            [ExpectedException(typeof(Exception),
   "Производной у остатка деления нет")]
            public void DiffRemainder_of_division() //
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = Diff(a % b);
                Assert.IsTrue(double.IsInfinity(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 })));
            }
        }
        [TestClass]
        public class DiffFunction
        {
            [TestMethod]
            public void DiffArsh()
            {
                var a = new Variable("a");
                var expr = Diff(Arsh(a));
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5 }), 0, 196);
            }

            [TestMethod]
            public void DiffArch()
            {
                var a = new Variable("a");
                var expr = Diff(Arch(a));
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5 }), 0, 204);
            }

            [TestMethod]
            public void DiffArth()
            {
                var a = new Variable("a");
                var expr = Diff(Arth(a));
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0.5 }), 1, 155);
            }

            [TestMethod]
            public void DiffArcth()
            {
                var a = new Variable("a");
                var expr = Diff(Arcth(a));
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0.5 }), 1, 333);
            }

            [TestMethod]
            public void DiffArsch()
            {
                var a = new Variable("a");
                var expr = Diff(Arsch(a));
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5 }), -0, 5);
            }

            [TestMethod]
            public void DiffArcsch()
            {
                var a = new Variable("a");
                var expr = Diff(Arcsch(a));
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 1 }), -1, 414);
            }

            [TestMethod]
            public void DiffSqrt()
            {
                var a = new Variable("a");
                var expr = Diff(Sqrt(a));
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 1 }), 0, 5);
            }
        }
    }

}