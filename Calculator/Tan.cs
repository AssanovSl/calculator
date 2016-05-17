using System;
namespace Calculator
{
   
        public class Tan: IOneCalculator
        {
            public double OneArgCalculate(double firstArg)
            {
                return Math.Tan(firstArg);
            }

        } 
    
}