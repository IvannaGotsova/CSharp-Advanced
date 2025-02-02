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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Clicked button one!";
            button1.Enabled = false;
            button5.Enabled = true;
            label1.Text = "Clicked!";
            Form2 formButtonOne = new Form2();
            formButtonOne.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Clicked button two!";
            button2.Enabled = false;
            button6.Enabled = true;
            label2.Text = "Clicked!";
            Form3 formButtonTwo = new Form3();
            formButtonTwo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Clicked button three!";
            button3.Enabled = false;
            button7.Enabled = true;
            label3.Text = "Clicked!";
            Form4 formButtonThree = new Form4();
            formButtonThree.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Clicked button four!";
            button4.Enabled = false;
            button8.Enabled = true;
            label4.Text = "Clicked!";
            Form5 formButtonFour = new Form5();
            formButtonFour.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Clicked button five!";
            button5.Enabled = false;
            button10.Enabled = true;
            label5.Text = "Clicked!";
            Form6 formButtonFive = new Form6();
            formButtonFive.ShowDialog();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
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
            label1.Text = "Clicked button one!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            button2.Enabled = true;
            button6.Enabled = false;
            label2.Text = "Clicked button two!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            button3.Enabled = true;
            button7.Enabled = false;
            label3.Text = "Clicked button three!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ";
            button4.Enabled = true;
            button8.Enabled = false;
            label4.Text = "Clicked button four!";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text = " ";
            button5.Enabled = true;
            button10.Enabled = false;
            label5.Text = "Clicked button five!";
        }
    }
}
