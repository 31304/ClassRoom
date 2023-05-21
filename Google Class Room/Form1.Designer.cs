using System.Drawing.Drawing2D;

namespace Google_Class_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 368);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.None;
            textBox.BackColor = Color.LightGray;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(133, 449);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "User Name";
            textBox.Size = new Size(242, 37);
            textBox.TabIndex = 1;
            textBox.Tag = "";
            textBox.TextChanged += textBox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(133, 510);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(242, 37);
            textBox1.TabIndex = 2;
            textBox1.Tag = "";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoEllipsis = true;
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(133, 573);
            button1.Name = "button1";
            button1.Size = new Size(242, 34);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.KeyPress += textBox1_KeyPress;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoEllipsis = true;
            button2.BackColor = Color.SeaGreen;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(133, 613);
            button2.Name = "button2";
            button2.Size = new Size(242, 34);
            button2.TabIndex = 4;
            button2.Text = "SinUP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(152, 489);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 17;
            label7.Text = "This user is not exist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(152, 550);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 18;
            label1.Text = "This user is not exist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(152, 489);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 19;
            label2.Text = "This field is required";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(152, 550);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 20;
            label3.Text = "This field is required";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 767);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}