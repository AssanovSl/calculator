using System;

namespace Calculator.TwoArg
{
    public class Desimal : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return Math.Pow(firstArg, 1 / secondArg);
        }
    }
}