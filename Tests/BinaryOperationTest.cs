using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using пз3;

namespace BinaryOperationTest
{
    [TestClass]
    public class BinaryOperationTest
    {
        [TestClass]
        public class Adittion
        {
            [TestMethod]
            public void AdditionPosPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 8);
            }

            [TestMethod]
            public void AdditionPosNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = -3 }), 2);
            }

            [TestMethod]
            public void AdditionNegPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 3 }), -2);
            }

            [TestMethod]
            public void AdditionNegNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = -3 }), -8);
            }

            [TestMethod]
            public void AdditionPosZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 0 }), 5);
            }

            [TestMethod]
            public void AdditionZeroPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 5 }), 5);
            }

            [TestMethod]
            public void AdditionNegZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 0 }), -5);
            }

            [TestMethod]
            public void AdditionZeroNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = -5 }), -5);
            }

            [TestMethod]
            public void AdditionZeroZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a + b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 0 }), 0);
            }

        }

        [TestClass]
        public class Subtraction
        {
            [TestMethod]
            public void SubtractionPosPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 2);
            }

            [TestMethod]
            public void SubtractionPosNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = -3 }), 8);
            }

            [TestMethod]
            public void SubtractionNegPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 3 }), -8);
            }

            [TestMethod]
            public void SubtractionNegNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = -3 }), -2);
            }

            [TestMethod]
            public void SubtractionPosZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 0 }), 5);
            }

            [TestMethod]
            public void SubtractionZeroPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 5 }), -5);
            }

            [TestMethod]
            public void SubtractionNegZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 0 }), -5);
            }

            [TestMethod]
            public void SubtractionZeroNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = -5 }), 5);
            }

            [TestMethod]
            public void SubtractionZeroZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a - b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 0 }), 0);
            }

        }

        [TestClass]
        public class Multiplication
        {
            [TestMethod]
            public void MultiplicationPosPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 15);
            }

            [TestMethod]
            public void MultiplicationPosNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = -3 }), -15);
            }

            [TestMethod]
            public void MultiplicationNegPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 3 }), -15);
            }

            [TestMethod]
            public void MultiplicationNegNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = -3 }), 15);
            }

            [TestMethod]
            public void MultiplicationPosZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 0 }), 0);
            }

            [TestMethod]
            public void MultiplicationZeroPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 5 }), 0);
            }

            [TestMethod]
            public void MultiplicationNegZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 0 }), 0);
            }

            [TestMethod]
            public void MultiplicationZeroNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = -5 }), 0);
            }

            [TestMethod]
            public void MultiplicationZeroZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a * b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 0 }), 0);
            }

        }

        [TestClass]
        public class Division
        {
            [TestMethod]
            public void DivisionPosPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 6, ["b"] = 3 }), 2);
            }

            [TestMethod]
            public void DivisionPosNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 6, ["b"] = -3 }), -2);
            }

            [TestMethod]
            public void DivisionNegPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -6, ["b"] = 3 }), -2);
            }

            [TestMethod]
            public void DivisionNegNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -6, ["b"] = -3 }), 2);
            }

            [TestMethod]
            [ExpectedException(typeof(System.Exception), "Делить на 0 нельзя")]
            public void DivisionPosZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.IsTrue(double.IsInfinity(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 0 })));
            }

            [TestMethod]
            public void DivisionZeroPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 5 }), 0);
            }

            [TestMethod]
            [ExpectedException(typeof(Exception), "Делить на 0 нельзя")]
            public void DivisionNegZero() //
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.IsTrue(double.IsFinite(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 0 })));
            }

            [TestMethod]
            public void DivisionZeroNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = -5 }), 0);
            }

            [TestMethod]
            [ExpectedException(typeof(Exception), "Делить на 0 нельзя")]
            public void DivisionZeroZero() //
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a / b;
                Assert.IsTrue(double.IsInfinity(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 0 })));
            }
        }

        [TestClass]
        public class Remainder_of_division
        {
            [TestMethod]
            public void Remainder_of_divisionPosPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 3 }), 2);
            }

            [TestMethod]
            public void Remainder_of_divisionPosNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = -3 }), 2);
            }

            [TestMethod]
            public void Remainder_of_divisionNegPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 3 }), -2);
            }

            [TestMethod]
            public void Remainder_of_divisionNegNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = -3 }), -2);
            }

            [TestMethod]
            public void Remainder_of_divisionPosZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 0 }), Double.NaN);
            }

            [TestMethod]
            public void Remainder_of_divisionZeroPos()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 5 }), 0);
            }

            [TestMethod]
            public void Remainder_of_divisionNegZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = -5, ["b"] = 0 }), Double.NaN);
            }

            [TestMethod]
            public void Remainder_of_divisionZeroNeg()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = -5 }), 0);
            }

            [TestMethod]
            public void Remainder_of_divisionZeroZero()
            {
                var a = new Variable("a");
                var b = new Variable("b");
                var expr = a % b;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["a"] = 0, ["b"] = 0 }), Double.NaN);
            }
        }
    }
}