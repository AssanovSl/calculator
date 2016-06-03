using System;

namespace Calculator.TwoArg
{
    /// <summary>
    /// класс реализующий функцию деления
    /// </summary>
    public class Division : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            if (secondArg == 0)
            {
                throw new ArgumentException("деление на нуль не возможно", "secondArg");
            }
            return firstArg/secondArg;
            
        }
    }

}