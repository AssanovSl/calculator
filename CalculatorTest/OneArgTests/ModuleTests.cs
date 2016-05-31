using Calculator;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
    [TestFixture]
    public class ModuleTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        public void ModuleTest(double firstValue, double expected)
        {
            IOneCalculator calculator = new Module();
            double result = calculator.OneArgCalculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}