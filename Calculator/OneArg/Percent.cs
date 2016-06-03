namespace Calculator.OneArg
{
    /// <summary>
    /// класс реализующий функцию вычисления процета
    /// </summary>
    public class Percent : IOneCalculator
    {
        public double OneArgCalculate(double firstArg)
        {
            return (firstArg/100);
        }
    }
}