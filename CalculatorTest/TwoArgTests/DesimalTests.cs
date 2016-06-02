using Calculator.TwoArg;
using NUnit.Framework;

namespace CalculatorTest.TwoArgTests
{
    [TestFixture]
    public class DesimalTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(3, 3, 1.44224)]
        [TestCase(5, 7, 1.25849)]
        public void DesimTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calculator = new Desimal();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}