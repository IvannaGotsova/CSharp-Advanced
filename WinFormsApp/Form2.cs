using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int firstNumber;
        int secondNumber;

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (firstNumber + secondNumber).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out firstNumber))
            {
                firstNumber = int.Parse(textBox1.Text);
            }
            else
            {
                textBox1.Text = "Enter Number!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out secondNumber))
            {
                secondNumber = int.Parse(textBox2.Text);
            }
            else
            {
                textBox2.Text = "Enter Number!";
            }          
        }
    }
}
