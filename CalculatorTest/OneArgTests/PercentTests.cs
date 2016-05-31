using Calculator;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class PercentTests
    {
        [TestCase(1, 0.01)]
        [TestCase(10, 0.1)]
        [TestCase(20, 0.2)]
        public void PercentTest(double firstValue, double expected)
        {
            IOneCalculator calculator = new Percent();
            double result = calculator.OneArgCalculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}