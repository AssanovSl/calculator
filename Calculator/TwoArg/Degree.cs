using System;

namespace Calculator.TwoArg
{
    /// <summary>
    /// класс реализующий функцию возведение в n-ую степень
    /// </summary>
    public class Degree : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return Math.Pow(firstArg, secondArg);
        }
    }
}