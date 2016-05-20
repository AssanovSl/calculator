using System;

namespace Calculator
{
    public class Module : IOneCalculator
    

{
    public double OneArgCalculate(double firstArg)
    {
        return Math.Abs(firstArg);
    }
}
}