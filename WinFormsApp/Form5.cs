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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                if (textBox1.Text != "STOP" || textBox1.Text != "stop") 
                { 
                    textBox2.Text = "NO"; 
                } 
                else 
                { textBox2.Text = "YES"; } 
            }
        }
    }
}
