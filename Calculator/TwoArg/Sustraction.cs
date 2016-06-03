namespace Calculator.TwoArg
{   
    /// <summary>
    /// класс реализующий функцию вычитания
    /// </summary>
    public class Sustraction : ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return firstArg - secondArg;
        }
    }
}