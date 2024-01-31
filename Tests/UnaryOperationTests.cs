using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using пз3;

namespace UnaryOperationTests
{
    [TestClass]
    public class UnaryPlusTest
    {
        [TestMethod]
        public void UnaryPlusPosTest()
        {
            var x = new Variable("x");
            var expr = +x;
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 1 }), 1);
        }

        [TestMethod]
        public void UnaryPlusZeroTest()
        {
            var x = new Variable("x");
            var expr = +x;
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 0 }), 0);
        }

        [TestMethod]
        public void UnaryPlusNegTest()
        {
            var x = new Variable("x");
            var expr = +x;
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = -1 }), -1);
        }
        [TestClass]
        public class UnaryMinusTest
        {
            [TestMethod]
            public void UnaryMinusPosTest()
            {
                var x = new Variable("x");
                var expr = -x;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 1 }), -1);
            }

            [TestMethod]
            public void UnaryMinusZeroTest()
            {
                var x = new Variable("x");
                var expr = -x;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 0 }), 0);
            }

            [TestMethod]
            public void UnaryMinusNegTest()
            {
                var x = new Variable("x");
                var expr = -x;
                Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = -1 }), 1);
            }
        }
    }
}