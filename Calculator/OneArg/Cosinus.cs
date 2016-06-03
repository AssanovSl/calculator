using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию вычисления косинуса (в радианах)
    /// </summary>
    public class Cosinus:IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Cos(firstArg);
        }

    }
    
}