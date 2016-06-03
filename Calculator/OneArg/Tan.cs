using System;

namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию вычисления тангенса (в радианах)
    /// </summary>
        public class Tan: IOneCalculator
        {
            public double OneArgCalculate(double firstArg)
            {
                if(firstArg % (Math.PI / 2) == 0)
                {
                     throw new ArgumentException("тангенс не существует", "firstArg");
                }
                return Math.Tan(firstArg);
            }

        } 
    
}