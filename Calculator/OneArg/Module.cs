using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию нахождения модуля числа
    /// </summary>
    public class Module : IOneCalculator
    {
    public double OneArgCalculate(double firstArg)
    {
        return Math.Abs(firstArg);
    }
}
}