using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию нахождения десятичного логарифма числа
    /// </summary>
    public class Ln : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return Math.Log10(firstArg);
        }

    }

}