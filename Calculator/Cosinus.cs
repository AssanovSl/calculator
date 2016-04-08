using System;
namespace Calculator
{
    public class Cosinus:IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Cos(firstArg);
        }

    }
    
}