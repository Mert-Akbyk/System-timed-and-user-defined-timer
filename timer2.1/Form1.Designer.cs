namespace timer2._1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 226);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 226);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 226);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 2;
            label3.Text = "00";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(194, 221);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(79, 27);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 196);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 4;
            label4.Text = "Hour:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 196);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 5;
            label5.Text = "Min:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 196);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 6;
            label6.Text = "Sec:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 196);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 7;
            label7.Text = "Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 271);
            label8.Name = "label8";
            label8.Size = new Size(227, 34);
            label8.TabIndex = 8;
            label8.Text = "Getting System Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(73, 146);
            label9.Name = "label9";
            label9.Size = new Size(165, 34);
            label9.TabIndex = 9;
            label9.Text = "Our Own Time";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 350);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 27);
            textBox1.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(181, 350);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(79, 27);
            maskedTextBox2.TabIndex = 11;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(77, 314);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 12;
            label10.Text = "Time:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(194, 314);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 13;
            label11.Text = "Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tempus Sans ITC", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 40);
            label12.Name = "label12";
            label12.Size = new Size(160, 61);
            label12.TabIndex = 14;
            label12.Text = "TimeR";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(-6, 126);
            label13.Name = "label13";
            label13.Size = new Size(459, 20);
            label13.TabIndex = 15;
            label13.Text = "---------------------------------------------------------------------------";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(-53, 251);
            label14.Name = "label14";
            label14.Size = new Size(459, 20);
            label14.TabIndex = 16;
            label14.Text = "---------------------------------------------------------------------------";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(328, 389);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox1;
    }
}
