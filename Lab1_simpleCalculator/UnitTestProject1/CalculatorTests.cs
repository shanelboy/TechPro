using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_simpleCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTests
    {
        Helper helper;
        public CalculatorTests()
        {
            helper = new Helper();
        }

        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            double num1 = 12.55;
            double num2 = 13.45;
            //Act
            double result = helper.add(num1, num2);
            //Assert
            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void TestAddZero()
        {
            //Arrange
            double num1 = 12.55;
            double num2 = 0;
            //Act
            double result = helper.add(num1, num2);
            //Assert
            Assert.AreEqual(12.55, result);
        }

        [TestMethod]
        public void TestAddNegativeNumber()
        {
            double num1 = 12.55;
            double num2 = -2.55;

            double result = helper.add(num1, num2);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMinus()
        {
            double num1 = 12.55;
            double num2 = 2.55;

            double result = helper.minus(num1, num2);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMinusNegativeNumber()
        {
            double num1 = 12.55;
            double num2 = -2.45;

            double result = helper.minus(num1, num2);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMulti()
        {
            double num1 = 12.55;
            double num2 = 2;

            double result = helper.multi(num1, num2);

            Assert.AreEqual(25.10, result);
        }

        [TestMethod]
        public void TestMultiZero()
        {
            double num1 = 12.55;
            double num2 = 0;

            double result = helper.multi(num1, num2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestDivideNegativeNumber()
        {
            double num1 = 12.55;
            double num2 = -2;

            double result = helper.multi(num1, num2);

            Assert.AreEqual(-25.1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideZero()
        {
            double num1 = 12.55;
            double num2 = 0;

            double result = helper.divide(num1, num2);
            Assert.AreEqual(0, result);
        }
    }
}

