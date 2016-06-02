using Calculator.OneArg;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
     [TestFixture]
    public class CosinusTests
    {
         [TestCase(0, 1)]
         [TestCase(1, 0.54030)]
         [TestCase(5, 0.28366)]
         public void CosTest(double firstValue, double expected)
         {
             IOneCalculator calculator = new Cosinus();
             double result = calculator.OneArgCalculate(firstValue);
             Assert.AreEqual(expected, result, 0.00001);
         }
    }
}