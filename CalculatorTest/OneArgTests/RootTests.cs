using Calculator;
using NUnit.Framework;


namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class RootTests
    {
        [TestCase(9, 3)]
        [TestCase(25, 5)]
        [TestCase(225, 15)]
        public void SqrtTest(double firstValue, double expected)
        {
            IOneCalculator calculator = new Root();
            double result = calculator.OneArgCalculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
