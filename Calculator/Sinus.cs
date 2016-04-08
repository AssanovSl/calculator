
using System;

namespace Calculator
{
   public class Sinus:IOneCalculator
    {
       public double OneArgCalculate(double firstArg)
        {
            return Math.Sin(firstArg);
        }

    }
}