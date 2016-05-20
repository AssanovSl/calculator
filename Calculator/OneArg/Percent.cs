namespace Calculator
{
    public class Percent : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return (firstArg/100);
        }
    }
}