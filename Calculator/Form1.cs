using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            double result;
            ICalculator calculator = CalculatorFactory.CreateCalculator(((Button) sender).Name);

           result = calculator.Calculate(firstArgDouble, secondArgDouble);


            outArg.Text = result.ToString();
        }

       private void OneArgCalculate(object sender, EventArgs e)
        {
            double firstArgDouble = Convert.ToDouble(firstArg.Text);
            

            double result;
            IOneCalculator calculator = OneArgFactory.CreateCalculator(((Button) sender).Name);

            result = calculator.OneArgCalculate(firstArgDouble);


            outArg.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
