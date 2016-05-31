using Calculator;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class CtanTests
    {
        [TestCase(1, 0.64209)]
        [TestCase(3, -7.01525)]
        [TestCase(5, -0.29581)]
        public void CtgTest(double firstValue, double expected)
        {
            IOneCalculator calculator = new Ctan();
            double result = calculator.OneArgCalculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}