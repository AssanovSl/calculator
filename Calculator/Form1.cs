using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Calculate(object sender, EventArgs e)
        {
            double firstArgDouble = Convert.ToDouble(firstArg.Text);
            double secondArgDouble = Convert.ToDouble(secondArg.Text);

            ICalculator calculator = CalculatorFactory.CreateCalculator(((Button)sender).Name);

            var result = calculator.Calculate(firstArgDouble, secondArgDouble);

            outArg.Text = result.ToString();
        }

        private void OneArgCalculate(object sender, EventArgs e)
        {
            double firstArgDouble = Convert.ToDouble(firstArg.Text);

            IOneCalculator calculator = OneArgFactory.CreateCalculator(((Button)sender).Name);

            var result = calculator.OneArgCalculate(firstArgDouble);

            outArg.Text = result.ToString();
        }


    }
}
