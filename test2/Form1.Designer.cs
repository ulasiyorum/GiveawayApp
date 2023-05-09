namespace test2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            numericUpDown3 = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(473, 68);
            button1.Name = "button1";
            button1.Size = new Size(139, 48);
            button1.TabIndex = 0;
            button1.Text = "Get number";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(372, 27);
            label1.Name = "label1";
            label1.Size = new Size(340, 20);
            label1.TabIndex = 1;
            label1.Text = "Press the button to get your number for giveaway!";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(473, 169);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 2;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(363, 127);
            label2.Name = "label2";
            label2.Size = new Size(360, 20);
            label2.TabIndex = 3;
            label2.Text = "Press the button to start the giveaway for one winner:";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(863, 32);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(863, 68);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            label4.Click += label4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(78, 114);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(139, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(78, 147);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(139, 27);
            numericUpDown2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(11, 125);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "From:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(29, 157);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 9;
            label6.Text = "To:";
            // 
            // button3
            // 
            button3.Location = new Point(372, 275);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(139, 49);
            button3.TabIndex = 10;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(364, 253);
            label7.Name = "label7";
            label7.Size = new Size(348, 20);
            label7.TabIndex = 11;
            label7.Text = "Press the button to start the giveaway for x winners:";
            label7.Visible = false;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(644, 295);
            numericUpDown3.Margin = new Padding(3, 4, 3, 4);
            numericUpDown3.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(56, 27);
            numericUpDown3.TabIndex = 12;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(607, 271);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 13;
            label8.Text = "(maximum 15)";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(622, 302);
            label9.Name = "label9";
            label9.Size = new Size(16, 20);
            label9.TabIndex = 14;
            label9.Text = "x";
            label9.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(78, 191);
            button4.Name = "button4";
            button4.Size = new Size(139, 48);
            button4.TabIndex = 15;
            button4.Text = "Auto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1134, 379);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(numericUpDown3);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Çekiliş Uygulaması";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label6;
        private Button button3;
        private Label label7;
        private NumericUpDown numericUpDown3;
        private Label label8;
        private Label label9;
        private Button button4;
    }
}