namespace Google_Class_Room
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            customPanel1 = new CustomPanel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            button7 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            customPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 128);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.SeaGreen;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(897, 34);
            button3.Name = "button3";
            button3.Size = new Size(83, 47);
            button3.TabIndex = 3;
            button3.Text = "Create";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.SeaGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1692, 24);
            button2.Name = "button2";
            button2.Size = new Size(83, 47);
            button2.TabIndex = 2;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 34);
            label1.Name = "label1";
            label1.Size = new Size(208, 47);
            label1.TabIndex = 1;
            label1.Text = "Create Class";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SeaGreen;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(11, 37);
            button1.Name = "button1";
            button1.Size = new Size(56, 44);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top;
            customPanel1.BorderColor = Color.White;
            customPanel1.BorderStyle = BorderStyle.FixedSingle;
            customPanel1.Controls.Add(label10);
            customPanel1.Controls.Add(label9);
            customPanel1.Controls.Add(label8);
            customPanel1.Controls.Add(button7);
            customPanel1.Controls.Add(textBox2);
            customPanel1.Controls.Add(textBox1);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(label2);
            customPanel1.Location = new Point(252, 198);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(515, 452);
            customPanel1.TabIndex = 5;
            customPanel1.Paint += customPanel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(63, 432);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 16;
            label10.Text = "Select Picture";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(63, 214);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 15;
            label9.Text = "This class already exist";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(63, 141);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 14;
            label8.Text = "This class already exist";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(46, 232);
            button7.Name = "button7";
            button7.Size = new Size(328, 197);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(46, 172);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "   Class Name";
            textBox2.Size = new Size(206, 39);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(46, 99);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Class Code";
            textBox1.Size = new Size(206, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 64);
            label3.Name = "label3";
            label3.Size = new Size(243, 15);
            label3.TabIndex = 1;
            label3.Text = "Enter the Class Code and share with students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 23);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 0;
            label2.Text = "Class Code";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(252, 668);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 249);
            panel2.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(295, 131);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Help Center Article";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(41, 131);
            label7.Name = "label7";
            label7.Size = new Size(248, 15);
            label7.TabIndex = 11;
            label7.Text = "If you have trouble joining the class, go to the";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 104);
            label6.Name = "label6";
            label6.Size = new Size(379, 15);
            label6.TabIndex = 10;
            label6.Text = "Use a class code with 5-7 letters or numbers, and no spaces or symbols";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 76);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 9;
            label5.Text = "Use an authorized account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 33);
            label4.Name = "label4";
            label4.Size = new Size(279, 30);
            label4.TabIndex = 8;
            label4.Text = "To sign in with a class code";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1015, 951);
            Controls.Add(panel1);
            Controls.Add(customPanel1);
            Controls.Add(panel2);
            MinimumSize = new Size(896, 769);
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private Button button1;
        private CustomPanel customPanel1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button3;
        private Button button7;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}