using System;

namespace Calculator.OneArg
{

    public class Exp : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Exp(firstArg);
        }
    }
}