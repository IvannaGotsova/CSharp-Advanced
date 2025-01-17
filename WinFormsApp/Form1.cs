namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Clicked button one!";
            button1.Enabled = false;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Clicked button two!";
            button2.Enabled = false;
            button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Clicked button three!";
            button3.Enabled = false;
            button7.Enabled = true;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Clicked button four!";
            button4.Enabled = false;
            button8.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            button1.Enabled = true;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            button2.Enabled = true;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            button3.Enabled = true;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ";
            button4.Enabled = true;
            button8.Enabled = false;
        }

    }
}
