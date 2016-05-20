using System;
namespace Calculator
{
    public class Log : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return Math.Log(firstArg, secondArg);
        } 
    }
}