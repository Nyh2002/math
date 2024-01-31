using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using οη3;

namespace ConstantAndVariableOperationsTests
{
    [TestClass]
    public class ConstantAndVariableOperationsTests
    {
        [TestMethod]
        public void ConstantTest()
        {
            var x = new Constant(1);
            var expr = x;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
        }

        [TestMethod]
        public void VariableTest()
        {
            var x = new Variable("x");
            var expr = x;
            Assert.AreEqual(expr.IsPolynom, true);
        }

        [TestMethod]
        public void NoConstantTest()
        {
            var x = new Variable("x");
            var expr = x;
            Assert.AreEqual(expr.IsConstant, false);
        }
    }
    [TestClass]
    public class ConstantAndVariableOperationsAdditionTest
    {
        [TestMethod]
        public void AdditionVariable()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr = a + b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void AdditionConstant()
        {
            var a = new Constant(2);
            var b = new Constant(5);
            var expr = a + b;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
        }
        [TestMethod]
        public void AdditionConstantAndVariable()
        {
            var a = new Variable("a");
            var b = new Constant(5);
            var expr = a + b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void AdditionVariableAndFunction()
        {
            var a = new Variable("a");
            var b = new Arch(5);
            var expr = a + b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void AdditionConstantAndFunction()
        {
            var a = new Constant(5);
            var b = new Arch(a);
            var expr = a + b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
        }
    }
    [TestClass]
    public class ConstantAndVariableOperationsSubtractionTest
    {
        [TestMethod]
        public void SubtractionVariable()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr = a - b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void SubtractionConstant()
        {
            var a = new Constant(2);
            var b = new Constant(5);
            var expr = a - b;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
        }
        [TestMethod]
        public void SubtractionConstantAndVariable()
        {
            var a = new Variable("a");
            var b = new Constant(5);
            var expr = a - b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void SubtractionVariableAndFunction()
        {
            var a = new Variable("a");
            var b = new Arch(5);
            var expr = a - b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void SubtractionConstantAndFunction()
        {
            var a = new Constant(5);
            var b = new Arch(a);
            var expr = a - b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
        }
    }
    [TestClass]
    public class ConstantAndVariableOperationsMultiplicationTest
    {
        [TestMethod]
        public void MultiplicationVariable()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr = a * b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void MultiplicationConstant()
        {
            var a = new Constant(2);
            var b = new Constant(5);
            var expr = a * b;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
        }
        [TestMethod]
        public void MultiplicationConstantAndVariable()
        {
            var a = new Variable("a");
            var b = new Constant(5);
            var expr = a * b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void MultiplicationVariableAndFunction()
        {
            var a = new Variable("a");
            var b = new Arch(5);
            var expr = a * b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void MultiplicationConstantAndFunction()
        {
            var a = new Constant(5);
            var b = new Arch(a);
            var expr = a * b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
        }
    }
    [TestClass]
    public class ConstantAndVariableOperationsDivisionTest
    {
        [TestMethod]
        public void DivisionVariable()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void DivisionConstant()
        {
            var a = new Constant(2);
            var b = new Constant(5);
            var expr = a / b;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
        }
        [TestMethod]
        public void DivisionVariableAndConstant()
        {
            var a = new Variable("a");
            var b = new Constant(5);
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void DivisionConstantAndVariable()
        {
            var a = new Variable("a");
            var b = new Constant(5);
            var expr = b / a;
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
        }

        [TestMethod]
        public void DivisionVariableAndFunction()
        {
            var a = new Variable("a");
            var b = new Arch(5);
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void DivisionConstantAndFunction()
        {
            var a = new Constant(5);
            var b = new Arch(a);
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
        }
    }
    [TestClass]
    public class ConstantAndVariableOperationsRemainder_of_divisionTest
    {
        [TestMethod]
        public void Remainder_of_divisionVariable()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void Remainder_of_divisionConstant()
        {
            var a = new Constant(2);
            var b = new Constant(5);
            var expr = a / b;
            Assert.AreEqual(expr.IsConstant, true);
            Assert.AreEqual(expr.IsPolynom, true);
        }
        [TestMethod]
        public void Remainder_of_divisionVariableAndConstant()
        {
            var a = new Variable("a");
            var b = new Constant(5);
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void Remainder_of_divisionConstantAndVariable()
        {
            var a = new Variable("a");
            var b = new Constant(5);
            var expr = b / a;
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
        }

        [TestMethod]
        public void Remainder_of_divisionVariableAndFunction()
        {
            var a = new Variable("a");
            var b = new Arch(5);
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void Remainder_of_divisionConstantAndFunction()
        {
            var a = new Constant(5);
            var b = new Arch(a);
            var expr = a / b;
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
        }
    }
    [TestClass]
    public class ConstantAndVariableFunctionTest
    {
        [TestMethod]
        public void ArshVariable()
        {
            var a = new Variable("a");
            var expr = new Arsh(a);
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void ArshConstant()
        {
            var a = new Constant(7);
            var expr = new Arsh(a);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
        }
        [TestMethod]
        public void ArchVariable()
        {
            var a = new Variable("a");
            var expr = new Arch(a);
            Assert.AreEqual(expr.IsPolynom, false);
            Assert.AreEqual(expr.IsConstant, false);
        }
        [TestMethod]
        public void ArchConstant()
        {
            var a = new Constant(7);
            var expr = new Arch(a);
            Assert.AreEqual(expr.IsPolynom, true);
            Assert.AreEqual(expr.IsConstant, true);
        }
    }
}