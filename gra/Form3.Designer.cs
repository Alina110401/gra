namespace gra
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label8 = new Label();
            comboBox5 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 133);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 197);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 2;
            label3.Text = "y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 86);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 3;
            label4.Text = "Dydelfy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 185);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 4;
            label5.Text = "Krokodyle";
           //abel5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 302);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 5;
            label6.Text = "Czas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(221, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 33);
            comboBox1.TabIndex = 6;
            comboBox1.Click += btnStart_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox2.Location = new Point(221, 206);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(116, 33);
            comboBox2.TabIndex = 7;
            comboBox2.Click += btnStart_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 308);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 9;
            label7.Text = "s";
          //label7.Click += label7_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox3.Location = new Point(559, 125);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(116, 33);
            comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0", "1" });
            comboBox4.Location = new Point(561, 232);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(116, 33);
            comboBox4.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(570, 300);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 12;
            label8.Text = "Szop";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8" });
            comboBox5.Location = new Point(559, 328);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(116, 33);
            comboBox5.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "plansza";
           //abel1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(570, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Akceptuj";
            button1.UseVisualStyleBackColor = true;
          //button1.Click += Akceptuj_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox5);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label7;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label8;
        private ComboBox comboBox5;
        private Label label1;
        private Button button1;
    }
}