using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox1.Text);
                double r2 = double.Parse(textBox2.Text);
                double r3 = double.Parse(textBox3.Text);
                double r4 = double.Parse(textBox7.Text);
                double r5 = double.Parse(textBox8.Text);
                double answer = r1 + r2 + r3 + r4 + r5;
                label1.Text = "Total resistance = " + answer.ToString();
            }
            catch
            {
                label1.Text = "Total resistance = ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox4.Text);
                double r2 = double.Parse(textBox5.Text);
                double r3 = double.Parse(textBox6.Text);
                double answer = 1.0 / (1.0 / r1 + 1.0 / r2 + 1.0 / r3 );
                label2.Text = "Total resistance = "+ answer.ToString();
            }
            catch
            {
                label2.Text = "Total resistance = ";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
