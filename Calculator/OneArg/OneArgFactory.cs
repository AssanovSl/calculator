using System;

namespace Calculator.OneArg
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

                case "exp":
                    return new Exp();

                case "tan":
                    return new Tan();

                case "ctg":
                    return new Ctan();

                case "Module":
                    return new Module();

                case "Percent":
                    return new Percent();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
