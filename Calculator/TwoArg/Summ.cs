namespace Calculator.TwoArg
{
    /// <summary>
    /// интерфейс калькулятора, для двух аргументов
    /// </summary>
    public class Summ : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return firstArg + secondArg;
        }


    }
}