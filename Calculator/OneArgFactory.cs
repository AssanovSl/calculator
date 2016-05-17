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

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
