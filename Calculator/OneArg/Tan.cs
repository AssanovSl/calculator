using System;

namespace Calculator.OneArg
{
   
        public class Tan: IOneCalculator
        {
            public double OneArgCalculate(double firstArg)
            {
                if((firstArg == 1.5708)|| (firstArg == 4.71239))
                {
                     throw new ArgumentException("тангенс не существует", "firstArg");
                }
                return Math.Tan(firstArg);
            }

        } 
    
}