using System;
namespace Calculator
{
    public class Root : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Sqrt(firstArg);
        }

    }
}