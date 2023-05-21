using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Class_Room
{
    public partial class Form6 : Form
    {
        string username;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        SqlDataReader dr1;
        private string message;
        public Form6(string Username, string message)
        {
            this.message = message;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
            this.username = Username;
            SqlConnection cn1 = new SqlConnection();
            cn1 = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            cm = new SqlCommand("select * from  StudentClassRoom where username = @username", cn);
            cm.Parameters.AddWithValue("@username", username);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string code = dr.GetString(1);
                    cn1.Open();
                    cm = new SqlCommand("select * from  ClassRoom where code=@code", cn1);
                    cm.Parameters.AddWithValue("@code", code);
                    dr1 = cm.ExecuteReader();
                    if (dr1.HasRows)
                    {
                        while (dr1.Read())
                        {

                            string code1 = dr1.GetString(0);
                            string name = dr1.GetString(2);
                            string imagepath = dr1.GetString(3);
                            Button button = new Button();
                            button.Text = name;
                            button.Size = new Size(328, 197);
                            button.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                            button.ForeColor = Color.White;
                            button.Tag = code1.ToString(); // Set the ID or name as the Tag
                            button.Click += Button_Click;        //button.Click += Button_Click;
                            button.Image = Image.FromFile(imagepath);
                            flowLayoutPanel1.Controls.Add(button);

                        }
                    }
                    cn1.Close();
                }
            }
            cn.Close();
            label1.Text = message;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }
        private void Button_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            Form18 form18 = new Form18(username, (string)button.Tag);
            form18.Size = this.Size;
            form18.Closed += (s, args) => this.Close();
            form18.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this.username);
            form4.Closed += (s, args) => this.Close();
            form4.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            char cha = username[0];
            if (char.IsLower(cha))
            {
                cha = (char)(cha - 32);
            }
            circularButton2.Text = char.ToString(cha);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Stop();
        }
    }
}
