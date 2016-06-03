using System;
using Calculator.OneArg;
using NUnit.Framework;
namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(1, 1.55740)]
        [TestCase(3, -0.14254)]
        [TestCase(5, -3.38051)]
        public void TanTest(double firstValue, double expected)
        {
            IOneCalculator calculator = new Tan();
            double result = calculator.OneArgCalculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
        [Test]
        public void TanTest()
        {
            IOneCalculator calculator = new Tan();
            Assert.Throws<ArgumentException>(() => calculator.OneArgCalculate(Math.PI / 2));
        }
    }
}