using Calculator;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(5, 3, 1.46497)]
        [TestCase(2, 7, 0.35620)]
        public void LogTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calculator = new Log();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}