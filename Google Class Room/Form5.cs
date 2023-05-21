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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Google_Class_Room
{

    public partial class Form5 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private string username;
        public Form5(string username)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this.username,"");
            form3.Closed += (s, args) => this.Close();
            form3.Show();
            this.Hide();
        }
        private string path;
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = textBox2.Text;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp, *.jpeg)|*.jpg;*.png;*.bmp;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                button7.Image = Image.FromFile(imagePath);
                path = imagePath;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button7.Text = textBox2.Text;
            error();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            string name = textBox2.Text;
            string imagepath = path;
            string username = this.username;
            cn.Open();
            cm = new SqlCommand("select * from ClassRoom where code = @code ", cn);
            cm.Parameters.AddWithValue("@code", code);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                label8.Visible = true;
                label9.Visible = true;
                button3.BackColor = Color.Red;
                cn.Close();
            }
            else
            {
                cn.Close();
                cn.Open();
                cm = new SqlCommand("insert into ClassRoom (code,username,name,imagepath) values (@code , @username,@name,@imagepath) ", cn);
                cm.Parameters.AddWithValue("@username", username);
                cm.Parameters.AddWithValue("@name", name);
                cm.Parameters.AddWithValue("@imagepath", imagepath);
                cm.Parameters.AddWithValue("@code", code);
                cm.ExecuteNonQuery();
                cn.Close();
                Form3 form3 = new Form3(this.username, "Create Class Sucessfully!");
                form3.Closed += (s, args) => this.Close();
                form3.Show();
                this.Hide();
            }

            /*  cn.Open();
              cm = new SqlCommand("DROP TABLE IF EXISTS ClassRoom", cn);
              cm.ExecuteNonQuery();
              cm = new SqlCommand("create table ClassRoom(code varchar(50) primary key(code),username varchar(40) not null,name varchar(30)  not null, imagepath varchar(300))", cn);
              cm.ExecuteNonQuery();
              cn.Close();*/
        }
        private void error()
        {
            label8.Visible = false;
            label9.Visible = false;
            button3.BackColor = Color.SeaGreen;
        }
        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {
            error();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            error();
        }
    }
}
