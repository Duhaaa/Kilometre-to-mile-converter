using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter2
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            //Initializes the form
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f;
            string input = mileBox.Text;
            
            //If the user didn't enter a digit
            if (!float.TryParse(input, out f))
            {
                MessageBox.Show("Only numbers are allowed!");
            }
            //else convert the input
            else
            {
                double calc = double.Parse(input);
                double sum = Math.Round(calc * 1.60934, 2);
                label3.Text = sum.ToString();
            }
        } 
    }
}