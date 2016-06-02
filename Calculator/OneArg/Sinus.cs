
using System;

namespace Calculator.OneArg
{
   public class Sinus:IOneCalculator
    {
       public double OneArgCalculate(double firstArg)
        {
            return Math.Sin(firstArg);
        }

    }
}