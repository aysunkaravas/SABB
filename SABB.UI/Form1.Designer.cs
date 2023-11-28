namespace SABB.UI
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
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            lblSifre = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 209, 55);
            panel1.BackgroundImage = Properties.Resources._2022_ldc_report_video_poster;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 405);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(94, 211);
            label4.Name = "label4";
            label4.Size = new Size(197, 23);
            label4.TabIndex = 3;
            label4.Text = "new account to connect us";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 184);
            label2.Name = "label2";
            label2.Size = new Size(271, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter your personal info and create";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(245, 246, 250);
            button1.FlatAppearance.BorderColor = Color.FromArgb(245, 246, 250);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(105, 264);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 1;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 113);
            label1.Name = "label1";
            label1.Size = new Size(160, 51);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 246, 250);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(lblSifre);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(365, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 405);
            panel2.TabIndex = 1;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(41, 273);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(30, 15);
            lblSifre.TabIndex = 12;
            lblSifre.Text = "Sifre";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Facebook1;
            pictureBox3.Location = new Point(247, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Instagram1;
            pictureBox2.Location = new Point(169, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Password;
            pictureBox5.Location = new Point(42, 234);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources._2022_ldc_report_video_poster;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(121, 304);
            button2.Margin = new Padding(20);
            button2.Name = "button2";
            button2.Size = new Size(160, 51);
            button2.TabIndex = 6;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.User1;
            pictureBox4.Location = new Point(42, 193);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(77, 58);
            label3.Name = "label3";
            label3.Size = new Size(242, 45);
            label3.TabIndex = 5;
            label3.Text = "Sign in to App";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Github;
            pictureBox1.Location = new Point(91, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(76, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(77, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Username";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.pngwing_com;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(343, 13);
            button3.Name = "button3";
            button3.Size = new Size(22, 23);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 403);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label lblSifre;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button3;
    }
}