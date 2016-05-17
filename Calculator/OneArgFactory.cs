using System;

namespace Calculator
{
    public static class OneArgFactory
    {
        public static IOneCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "sin":
                    return new Sinus();

                case "cos":
                    return new Cosinus();

                case "ln":
                    return new Ln();

                case "sqrt":
                    return new Root();

                case "desimal":
                    return new Desimal();

                case "exp":
                    return new Exp();

                case "tan":
                    return new Tan();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
