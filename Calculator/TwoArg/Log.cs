using System;

namespace Calculator.TwoArg
{
    /// <summary>
    /// класс реализующий функцию логарифма
    /// </summary>
    public class Log : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            if ((secondArg <= 0) || (secondArg == 1))
            {
                 throw new ArgumentException("не корректное основание логарифма", "secondArg");
            }
            return Math.Log(firstArg, secondArg);
        } 
    }
}