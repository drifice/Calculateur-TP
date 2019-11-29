using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestAddition()
        {

            int a = 1;
            int b = 2;
            int expepted = 3;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Addition(a, b);
            Assert.AreEqual(expepted, actual);

        }

        [TestMethod]
        public void TestSubstraction()
        {

            int a = 2;
            int b = 1;
            int expepted = 1;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Substraction(a, b);
            Assert.AreEqual(expepted, actual);

        }

        [TestMethod]
        public void TestMultiplication()
        {

            int a = 2;
            int b = 1;
            int expepted = 2;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Multiplication(a, b);
            Assert.AreEqual(expepted, actual);

        }

        [TestMethod]
        public void TestDivision()
        {

            int a = 2;
            int b = 1;
            int expepted = 2;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);
            Assert.AreEqual(expepted, actual);

        }
        [TestMethod]
        public void TestDivParZero()
        {

            int a = 2;
            int b = 0;
            int expepted = Int32.MinValue;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);
            Assert.AreEqual(expepted, actual);

        }

    }
}
