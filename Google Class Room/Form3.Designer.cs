namespace Google_Class_Room
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            circularButton1 = new CircularButton();
            panel1 = new Panel();
            label1 = new Label();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(128, 40);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(368, 47);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "GOOGLE CLASSROOM";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.SeaGreen;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(12, 40);
            button3.Name = "button3";
            button3.Size = new Size(81, 55);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SeaGreen;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(706, 40);
            button2.Name = "button2";
            button2.Size = new Size(81, 55);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SeaGreen;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(805, 40);
            button1.Name = "button1";
            button1.Size = new Size(81, 55);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // circularButton1
            // 
            circularButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            circularButton1.AutoSize = true;
            circularButton1.BackColor = Color.DarkBlue;
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            circularButton1.ForeColor = Color.White;
            circularButton1.Location = new Point(912, 30);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(86, 76);
            circularButton1.TabIndex = 0;
            circularButton1.Text = "T";
            circularButton1.UseVisualStyleBackColor = false;
            circularButton1.Click += circularButton1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(circularButton1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 129);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 93);
            label1.Name = "label1";
            label1.Size = new Size(304, 32);
            label1.TabIndex = 8;
            label1.Text = "You are Login Sucessfully";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.SeaGreen;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(1697, 24);
            button4.Name = "button4";
            button4.Size = new Size(83, 47);
            button4.TabIndex = 2;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(28, 157);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(961, 561);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1013, 730);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            MinimumSize = new Size(896, 769);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CircularButton circularButton1;
        private Button button2;
        private Button button1;
        private Button button3;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}