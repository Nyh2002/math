using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using пз3;
using static пз3.GroupFunction;

namespace FunctionTests
{

    [TestClass]
    public class ArshTests
    {
        [TestMethod]
        public void ArshTestPos()
        {
            var x = new Variable("x");
            var expr = new Arsh(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 1 }), Math.Asinh(1), 0.0001);
        }

        [TestMethod]
        public void ArshTestNeg()
        {
            var x = new Variable("x");
            var expr = new Arsh(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = -1 }), Math.Asinh(-1), 0.0001);
        }
    }

    [TestClass]
    public class ArchTests
    {
        [TestMethod]
        public void ArchTest()
        {
            var x = new Variable("x");
            var expr = new Arch(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 5 }), Math.Acosh(5), 0.0001);
        }

        [TestMethod]
        public void ArchTest1()
        {
            var x = new Variable("x");
            var expr = new Arch(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 1 }), Math.Acosh(1), 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Не из области определения")]
        public void ArchTestNo() //
        {
            var x = new Variable("x");
            var expr = new Arch(x);
            Assert.IsTrue(double.IsInfinity(expr.Compute(new Dictionary<string, double> { ["x"] = 0 })));
        }
    }
    [TestClass]
    public class ArthTests
    {
        [TestMethod]
        public void ArthTestPos()
        {
            var x = new Variable("x");
            var expr = new Arth(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 0.5 }), Math.Atanh(0.5), 0.0001);
        }

        [TestMethod]
        public void ArthTestNeg()
        {
            var x = new Variable("x");
            var expr = new Arth(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = -0.5 }), Math.Atanh(-0.5), 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Не из области определения")]
        public void ArthTestNo() //
        {
            var x = new Variable("x");
            var expr = new Arth(x);
            Assert.IsTrue(double.IsInfinity(expr.Compute(new Dictionary<string, double> { ["x"] = 10 })));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Не из области определения")]
        public void ArthTest0() //
        {
            var x = new Variable("x");
            var expr = new Arth(x);
            Assert.IsTrue(double.IsFinite(expr.Compute(new Dictionary<string, double> { ["x"] = 0 })));
        }
    }
    [TestClass]
    public class ArcthTests
    {
        [TestMethod]
        public void ArcthTestPos()
        {
            var x = new Variable("x");
            var expr = new Arcth(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 2 }), 0.549306, 0.0001);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception), "Не из области определения")]
        public void ArcthTest0() //
        {
            var x = new Variable("x");
            var expr = new Arcth(x);
            Assert.IsTrue(double.IsFinite(expr.Compute(new Dictionary<string, double> { ["x"] = 0 })));
        }
    }
    [TestClass]
    public class ArschTests
    {
        [TestMethod]
        public void ArschTestPos()
        {
            var x = new Variable("x");
            var expr = new Arsch(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 0.5 }), 1.31696, 0.0001);
        }

        [TestMethod]
        public void ArschTest1()
        {
            var x = new Variable("x");
            var expr = new Arsch(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 1 }), 0, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Не из области определения")]
        public void ArschTestNoPos() //
        {
            var x = new Variable("x");
            var expr = new Arsch(x);
            Assert.IsTrue(double.IsFinite(expr.Compute(new Dictionary<string, double> { ["x"] = 10 })));
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Не из области определения")]
        public void ArschTestNoNeg() //
        {
            var x = new Variable("x");
            var expr = new Arsch(x);
            Assert.IsTrue(double.IsFinite(expr.Compute(new Dictionary<string, double> { ["x"] = -10 })));
        }
    }
    [TestClass]
    public class ArcschTests
    {
        [TestMethod]
        public void ArcschTestPos()
        {
            var x = new Variable("x");
            var expr = new Arcsch(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = 1 }), 0.881374, 0.0001);
        }
        [TestMethod]
        public void ArcschTestNeg()
        {
            var x = new Variable("x");
            var expr = new Arcsch(x);
            Assert.AreEqual(expr.Compute(new Dictionary<string, double> { ["x"] = -1 }), -0.881374, 0.0001);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Не из области определения")]
        public void ArcschTestNo() //
        {
            var x = new Variable("x");
            var expr = new Arcsch(x);
            Assert.IsFalse(double.IsFinite(expr.Compute(new Dictionary<string, double> { ["x"] = 0 })));
        }
    }
}