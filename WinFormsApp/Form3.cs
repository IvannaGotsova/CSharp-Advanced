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
            if (int.Parse(textBox4.Text) >= 18)
            {
                textBox6.Text = $"The full name is {textBox1.Text} {textBox2.Text} {textBox3.Text}. the age is {textBox4.Text}. The city is {textBox5.Text}.";
            }
            else
            {
                textBox4.Text = "Enter age";
            }
        }
    }
}
