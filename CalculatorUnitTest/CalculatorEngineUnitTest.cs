using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestAdd()
        {

            int a = 1;
            int b = 2;
            int expepted = 3;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.add(a, b);
            Assert.AreEqual(expepted, actual);

        }

        [TestMethod]
        public void TestSub()
        {

            int a = 2;
            int b = 1;
            int expepted = 1;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Sub(a, b);
            Assert.AreEqual(expepted, actual);

        }

        [TestMethod]
        public void TestMul()
        {

            int a = 2;
            int b = 1;
            int expepted = 2;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Mul(a, b);
            Assert.AreEqual(expepted, actual);

        }

        [TestMethod]
        public void TestDiv()
        {

            int a = 2;
            int b = 1;
            int expepted = 2;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);
            Assert.AreEqual(expepted, actual);

        }
        [TestMethod]
        public void TestDivParZero()
        {

            int a = 2;
            int b = 0;
            int expepted = Int32.MinValue;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);
            Assert.AreEqual(expepted, actual);

        }

    }
}
