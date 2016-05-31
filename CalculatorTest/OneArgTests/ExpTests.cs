using Calculator;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 2.71828)]
        [TestCase(3, 20.08553)]
        public void ExpTest(double firstValue, double expected)
        {
            IOneCalculator calculator = new Exp();
            double result = calculator.OneArgCalculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}