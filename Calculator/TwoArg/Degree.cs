using System;

namespace Calculator.TwoArg
{
    public class Degree : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return Math.Pow(firstArg, secondArg);
        }
    }
}