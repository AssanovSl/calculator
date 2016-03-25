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

        private void button1_Click(object sender, EventArgs e)
        {
            double firstArgDouble = Convert.ToDouble(firstArg.Text);
            double secondArgDouble = Convert.ToDouble(secondArg.Text);

            double result = secondArgDouble + firstArgDouble;

            outArg.Text = result.ToString();

            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double firstArgDouble = Convert.ToDouble(firstArg.Text);
            double secondArgDouble = Convert.ToDouble(secondArg.Text);

            double result = firstArgDouble  - secondArgDouble;

            outArg.Text = result.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstArgDouble = Convert.ToDouble(firstArg.Text);
            double secondArgDouble = Convert.ToDouble(secondArg.Text);

            double result = firstArgDouble / secondArgDouble;

            outArg.Text = result.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double firstArgDouble = Convert.ToDouble(firstArg.Text);
            double secondArgDouble = Convert.ToDouble(secondArg.Text);

            double result = secondArgDouble * firstArgDouble;

            outArg.Text = result.ToString();
        }
    }
}
