using Calculator;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.84147)]
        [TestCase(4, -0.75680)]
        public void SinTest(double firstValue, double expected)
        {
            IOneCalculator calculator = new Sinus();
            double result = calculator.OneArgCalculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
