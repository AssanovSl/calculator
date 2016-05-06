using System;
namespace Calculator
{

    public class Exp : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Exp(firstArg);
        }
    }
}