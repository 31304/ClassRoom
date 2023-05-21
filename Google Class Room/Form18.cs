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
    public partial class Form18 : Form
    {
        private string username;
        private string classid;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public Form18(string username, string classid)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
            this.username = username;
            this.classid = classid;
            panel2.Visible = false;
            cn.Open();
            cm = new SqlCommand("select * from  Assingment where code = @code", cn);
            cm.Parameters.AddWithValue("@code", classid);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string title = dr.GetString(1);
                    string imagepath = "C:\\Users\\samii\\Downloads\\icons8-assignment-100.png";
                    Button button = new Button();
                    button.Text = title;
                    button.Size = new Size(944, 101);
                    button.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                    button.BackColor = Color.Gray;
                    button.Tag = id; // Set the ID or name as the Tag
                    button.Click += Button_Click_Assignment1;        //button.Click += Button_Click;
                    button.Image = Image.FromFile(imagepath);
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.MouseHover += Button_MouseHover;
                    button.MouseMove += Button_MouseMove;
                    flowLayoutPanel1.Controls.Add(button);

                    panel1 = new Panel();
                    
                }

            }
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select * from  ClassMaterial where code = @code", cn);
            cm.Parameters.AddWithValue("@code", classid);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string title = dr.GetString(1);
                    string imagepath = "C:\\Users\\samii\\Downloads\\icons8-pdf-96.png";
                    Button button = new Button();
                    button.Text = title;
                    button.Size = new Size(944, 101);
                    button.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                    button.BackColor = Color.Gray;
                    button.Tag = id; // Set the ID or name as the Tag
                    button.Click += Button_Click_Assignment2;        //button.Click += Button_Click;
                    button.Image = Image.FromFile(imagepath);
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.MouseHover += Button_MouseHover;
                    button.MouseMove += Button_MouseMove;
                    flowLayoutPanel1.Controls.Add(button);
                }

            }
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select * from Announcement where code = @code", cn);
            cm.Parameters.AddWithValue("@code", classid);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string title = dr.GetString(1);
                    string imagepath = "C:\\Users\\samii\\Downloads\\icons8-announcement-80.png";
                    Button button = new Button();
                    button.Text = title;
                    button.Size = new Size(944, 101);
                    button.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                    button.BackColor = Color.Gray;
                    button.Tag = id; // Set the ID or name as the Tag
                    button.Click += Button_Click_Assignment3;        //button.Click += Button_Click;
                    button.Image = Image.FromFile(imagepath);
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.MouseHover += Button_MouseHover;
                    button.MouseMove += Button_MouseMove;
                    flowLayoutPanel1.Controls.Add(button);
                }

            }
            cn.Close();

        }
        private void Button_Click_Assignment3(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            Form17 form17 = new Form17((int)button.Tag, username, classid);
            form17.Size = this.Size;
            form17.Closed += (s, args) => this.Close();
            form17.Show();
            this.Hide();
        }

        private void Button_Click_Assignment1(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            Form15 form15 = new Form15((int)button.Tag, username, classid);
            form15.Size = this.Size;
            form15.Closed += (s, args) => this.Close();
            form15.Show();
            this.Hide();
        }

        private void Button_MouseMove(object? sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Gray;
        }
        private void Button_MouseHover(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.SeaGreen;
        }

        private void Button_Click_Assignment2(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            Form16 form16 = new Form16((int)button.Tag, username, classid);
            form16.Size = this.Size;
            form16.Closed += (s, args) => this.Close();
            form16.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(username, "");
            form6.Size = this.Size;
            form6.Closed += (s, args) => this.Close();
            form6.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            cm = new SqlCommand("Delete from StudentClassRoom  where code = @code", cn);
            cm.Parameters.AddWithValue("@code", classid);
            cm.ExecuteNonQuery();
            cn.Close();
            Form6 form6 = new Form6(username, "You Enroll the ClassRoom");
            form6.Size = this.Size;
            form6.Closed += (s, args) => this.Close();
            form6.Show();
            this.Hide();
        }
    }
}
