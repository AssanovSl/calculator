using Calculator.TwoArg;
using NUnit.Framework;

namespace CalculatorTest.TwoArgTests
{
    [TestFixture]
    public class SustractionTests
    {
        [TestCase(5, 3, 2)]
        [TestCase(500, 100, 400)]
        [TestCase(50, 2, 48)]
        public void MinusTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calculator = new Sustraction();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}