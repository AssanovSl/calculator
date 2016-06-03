using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию нахождения экспоненты числа
    /// </summary>
    public class Exp : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Exp(firstArg);
        }
    }
}