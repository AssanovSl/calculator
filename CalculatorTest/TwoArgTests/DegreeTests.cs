using Calculator;
using NUnit.Framework;

namespace CalculatorTest.TwoArgTests
{
    [TestFixture]
    public class DegreeTests
    {
        [TestCase(2, 4, 16)]
        [TestCase(3, 4, 81)]
        [TestCase(5, 7, 78125)]
        public void DegreeTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calculator = new Degree();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}