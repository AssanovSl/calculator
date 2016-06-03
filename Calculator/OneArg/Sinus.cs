
using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию вычисления синуса (в радианах)
    /// </summary>
   public class Sinus:IOneCalculator
    {
       public double OneArgCalculate(double firstArg)
        {
            return Math.Sin(firstArg);
        }

    }
}