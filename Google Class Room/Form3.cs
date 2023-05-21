using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Google_Class_Room
{
    public partial class Form3 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private string username;
        private string message;
        public Form3(string Username, string message)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            this.message = message;
            InitializeComponent();
            this.username = Username;
            cn.Open();
            cm = new SqlCommand("select * from  ClassRoom where username=@username", cn);
            cm.Parameters.AddWithValue("@username", username);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    string code = dr.GetString(0);
                    string name = dr.GetString(2);
                    string imagepath = dr.GetString(3);
                    Button button = new Button();
                    button.Text = name;
                    button.Size = new Size(328, 197);
                    button.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                    button.ForeColor = Color.White;
                    button.Tag = code.ToString(); // Set the ID or name as the Tag
                    button.Click += Button_Click;
                    button.Image = Image.FromFile(imagepath);
                    flowLayoutPanel1.Controls.Add(button);

                }
            }
            label1.Text = message;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            cn.Close();
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            Form7 form7 = new Form7(username, classid: (string)button.Tag);
            form7.Size=this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://classroom.google.com";

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                MessageBox.Show("Error opening URL: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this.username);
            form5.Closed += (s, args) => this.Close();
            form5.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Stop();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            char cha = username[0];
            if (char.IsLower(cha))
            {
                cha =(char) (cha - 32);
            }
            circularButton1.Text = char.ToString(cha);
        }
    }
}
