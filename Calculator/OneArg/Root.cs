using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию вычисления квадратного корня
    /// </summary>
    public class Root : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            if (firstArg < 0)
            {
                throw new ArgumentException("корень квадратный из отрицательного не возможно", "firstArg");
            }
            return Math.Sqrt(firstArg);
        }

    }
}