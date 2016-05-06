using System;
namespace Calculator
{
    public class Ln : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Log10(firstArg);
        }

    }

}