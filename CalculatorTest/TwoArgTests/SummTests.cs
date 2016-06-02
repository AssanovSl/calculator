using Calculator.TwoArg;
using NUnit.Framework;

namespace CalculatorTest.TwoArgTests
{
    [TestFixture]
    public class SummTests
    {
        [TestCase(2, 3, 5)]
        [TestCase(100, 500, 600)]
        [TestCase(50, 2, 52)]
        public void PlusTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calculator = new Summ();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}