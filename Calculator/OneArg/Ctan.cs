using System;
namespace Calculator
{
    public class Ctan : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return 1/Math.Tan(firstArg);
        }

    }

}