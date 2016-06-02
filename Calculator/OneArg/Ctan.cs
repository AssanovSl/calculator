using System;

namespace Calculator.OneArg
{
    public class Ctan : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            if ((firstArg == 0) || (firstArg == 3.14159) || (firstArg == 6.28319))
            {
                throw new ArgumentException("катангенс не существует", "firstArg");
            }
            return 1/Math.Tan(firstArg);
        }

    }

}