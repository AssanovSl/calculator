using System;

namespace Calculator.OneArg
{
    public class Cosinus:IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Cos(firstArg);
        }

    }
    
}