namespace Calculator.TwoArg
{
    /// <summary>
    /// класс реализующий функцию умножения
    /// </summary>
    public class Multiplication:ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return firstArg * secondArg;
        } 
    }
}