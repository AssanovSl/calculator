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
            switch (((Button)sender).Name)
            {
                case "plus":
                    result = secondArgDouble + firstArgDouble;
                    break;
                case "minus":
                    result = firstArgDouble - secondArgDouble;
                    break;
                case "multiply":
                    result = secondArgDouble * firstArgDouble;
                    break;
                case "divide":
                    result = firstArgDouble / secondArgDouble;
                    break;
                default: 
                    throw new Exception("Неизвестная операция");
                    

            }

            outArg.Text = result.ToString();
        }

       
    }
}
