using System;

namespace Calculator.OneArg
{
    public class Module : IOneCalculator
    

{
    public double OneArgCalculate(double firstArg)
    {
        return Math.Abs(firstArg);
    }
}
}