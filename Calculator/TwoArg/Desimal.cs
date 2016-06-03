using System;

namespace Calculator.TwoArg
{
    /// <summary>
    /// класс реализующий функцию извлечения корня n-ой степени
    /// </summary>
    public class Desimal : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return Math.Pow(firstArg, 1 / secondArg);
        }
    }
}