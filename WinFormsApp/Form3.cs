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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isRight = true;

            if (textBox1.Text.Length < 2 || textBox1.Text.Length > 99)
            {
                textBox1.Text = "Enter First Name";
                isRight = false;
            }

            if (textBox2.Text.Length < 2 || textBox2.Text.Length > 99)
            {
                textBox2.Text = "Enter Middle Name";
                isRight = false;
            }

            if (textBox3.Text.Length < 2 || textBox3.Text.Length > 99)
            {
                textBox3.Text = "Enter Last Name";
                isRight = false;
            };

            int age  = int.Parse(textBox4.Text);

            if (age > 2 || age < 100)
            {
                textBox4.Text = "Enter age";
                isRight = false;
            }

            if (textBox5.Text.Length < 2 || textBox5.Text.Length > 20)
            {
                textBox5.Text = "Enter City";
                isRight = false;
            }

            if (isRight)
            {
                textBox6.Text = $"The full name is {textBox1.Text} {textBox2.Text} {textBox3.Text}. the age is {textBox4.Text}. The city is {textBox5.Text}.";
            }
        }
    }
}
