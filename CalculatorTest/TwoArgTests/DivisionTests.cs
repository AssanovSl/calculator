using Calculator;
using NUnit.Framework;

namespace CalculatorTest.TwoArgTests
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(8, 4, 2)]
        [TestCase(50, 25, 2)]
        [TestCase(48, 8, 6)]
        public void DelitTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calculator = new Division();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}