using Calculator.TwoArg;
using NUnit.Framework;

namespace CalculatorTest.TwoArgTests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(2, 3, 6)]
        [TestCase(100, 5, 500)]
        [TestCase(4, 7, 28)]
        public void MultiplayTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calculator = new Multiplication();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}