namespace Calculator
{
    public class Multiplication:ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return firstArg * secondArg;
        } 
    }
}