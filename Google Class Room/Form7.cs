using iTextSharp.text.pdf.qrcode;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace Google_Class_Room
{
    public partial class Form7 : Form
    {
        private string username;
        private string classid;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public Form7(string username, string classid)
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
            Form13 form13 = new Form13((int)button.Tag, username, classid);
            form13.Size = this.Size;
            form13.Closed += (s, args) => this.Close();
            form13.Show();
            this.Hide();
        }

        private void Button_Click_Assignment1(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            Form11 form11 = new Form11((int)button.Tag, username, classid);
            form11.Size = this.Size;
            form11.Closed += (s, args) => this.Close();
            form11.Show();
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
            Form12 form12 = new Form12((int)button.Tag, username, classid);
            form12.Size = this.Size;
            form12.Closed += (s, args) => this.Close();
            form12.Show();
            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(classid, username, "1", 0);
            form8.Size = this.Size;
            form8.Closed += (s, args) => this.Close();
            form8.Show();
            this.Hide();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(classid, username, "1", 0);
            form10.Size = this.Size;
            form10.Closed += (s, args) => this.Close();
            form10.Show();
            this.Hide();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(classid, username, "1", 0);
            form9.Size = this.Size;
            form9.Closed += (s, args) => this.Close();
            form9.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(username, "");
            form3.Size = this.Size;
            form3.Closed += (s, args) => this.Close();
            form3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("Delete from ClassRoom  where code = @code", cn);
            cm.Parameters.AddWithValue("@code", classid);
            cm.ExecuteNonQuery();
            cn.Close();
            Form3 form3 = new Form3(username, "Class Deleted Sucessfully");
            form3.Size = this.Size;
            form3.Closed += (s, args) => this.Close();
            form3.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21(username, classid);
            form21.Size = this.Size;
            form21.Closed += (s, args) => this.Close();
            form21.Show();
            this.Hide();
        }
    }
}
