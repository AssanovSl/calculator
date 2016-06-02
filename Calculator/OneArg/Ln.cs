using System;

namespace Calculator.OneArg
{
    public class Ln : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Log10(firstArg);
        }

    }

}