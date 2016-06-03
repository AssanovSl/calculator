using System;

namespace Calculator.TwoArg
{
    /// <summary>
    /// фабрика для реализации операций с двумя аргументами
    /// </summary>
    public static class CalculatorFactory   
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "plus":
                    return new Summ();
                case "minus":
                    return new Sustraction();
                case "multiply":
                    return new Multiplication();
                case "divide":
                    return new Division();
                case "degree":
                    return new Degree();
                case "desimal":
                    return new Desimal();
                case "Log":
                    return new Log();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}