using Calculator.OneArg;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
     [TestFixture]
    public class LnTests
    {
         [TestCase(1, 0)]
         [TestCase(2, 0.30102)]
         [TestCase(3, 0.47712)]
         public void LnTest(double firstValue, double expected)
         {
             IOneCalculator calculator = new Ln();
             double result = calculator.OneArgCalculate(firstValue);
             Assert.AreEqual(expected, result, 0.00001);
         }
    }
}