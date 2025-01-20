namespace WinFormsApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 363);
            button1.Name = "button1";
            button1.Size = new Size(168, 43);
            button1.TabIndex = 0;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Middle Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 4;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 270);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 5;
            label5.Text = "City";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 193);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(298, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(96, 262);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(298, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(455, 66);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(284, 23);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(455, 26);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "RESULT";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
    }
}