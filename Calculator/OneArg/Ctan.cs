using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию вычисления котангенса (в радианах)
    /// </summary>
    public class Ctan : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            if (firstArg % Math.PI == 0)
            {
                throw new ArgumentException("катангенс не существует", "firstArg");
            }
            return 1/Math.Tan(firstArg);
        }

    }

}