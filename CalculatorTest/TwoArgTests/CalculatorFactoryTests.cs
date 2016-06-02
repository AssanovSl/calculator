using System;
using Calculator.TwoArg;
using NUnit.Framework;

namespace CalculatorTest.TwoArgTests
{
    public class CalculatorFactoryTests
    {
        [TestCase("plus", typeof(Summ))]
        [TestCase("minus", typeof(Sustraction))]
        [TestCase("multiply", typeof(Multiplication))]
        [TestCase("divide", typeof(Division))]
        [TestCase("degree", typeof(Degree))]
        [TestCase("desimal", typeof(Desimal))]
        [TestCase("Log", typeof(Log))]
       

        public void OneArgFactoryTest(string name, Type type)
        {
            ICalculator calculator = CalculatorFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }  
    }
}