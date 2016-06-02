using System;
using Calculator.OneArg;
using NUnit.Framework;

namespace CalculatorTest.OneArgTests
{
    public class OneArgFactoryTests 
    {
        [TestCase("sin", typeof(Sinus))]
        [TestCase("cos", typeof(Cosinus))]
        [TestCase("ln", typeof(Ln))]
        [TestCase("sqrt", typeof(Root))]
        [TestCase("exp", typeof(Exp))]
        [TestCase("tan", typeof(Tan))]
        [TestCase("Module", typeof(Module))]
        [TestCase("ctg", typeof(Ctan))]
        [TestCase("Percent", typeof(Percent))]

        public void OneArgFactoryTest(string name, Type type)
        {
            IOneCalculator calculator = OneArgFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        } 
    }
}