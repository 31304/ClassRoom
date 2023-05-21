using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Google_Class_Room
{
    public partial class Form4 : Form
    {
        private string username;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        SqlDataReader dr1;
        public Form4(string username)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this.username,"");
            form6.Closed += (s, args) => this.Close();
            form6.Show();
            this.Hide();
        }

        private void error()
        {
            label8.Visible = false;
            label9.Visible = false;
            button2.BackColor = Color.SeaGreen;
        }
        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {
            error();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*cn.Open();
            cm = new SqlCommand("DROP TABLE IF EXISTS StudentClassRoom", cn);
            cm.ExecuteNonQuery();
            cm = new SqlCommand("create table StudentClassRoom (username varchar(50) foreign key(username) references systemUser(username) on delete cascade,code varchar(50) foreign key(code)references ClassRoom(code)  on delete cascade)", cn);
            cm.ExecuteNonQuery();
            cn.Close();*/
           cn.Open();
            cm = new SqlCommand("select * from StudentClassRoom where code= @code and username=@username", cn);
            cm.Parameters.AddWithValue("@code", textBox1.Text);
            cm.Parameters.AddWithValue("@username", username);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                cn.Close();
                label9.Visible = true;
            }
            else
            {
                cn.Close();
                cn.Open();
                cm = new SqlCommand("select * from ClassRoom where code= @code ", cn);
                cm.Parameters.AddWithValue("@code", textBox1.Text);
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string code = dr.GetString(0);
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("insert into StudentClassRoom (username,code) values(@username,@code)", cn);
                    cm.Parameters.AddWithValue("@username", username);
                    cm.Parameters.AddWithValue("@code", code);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Form6 form6 = new Form6(this.username, "Join class Sucessfully!");
                    form6.Closed += (s, args) => this.Close();
                    form6.Show();
                    this.Hide();
                }
                else
                {
                    label8.Visible = true;

                    button2.BackColor = Color.Red;
                }
                cn.Close();
            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            error();
        }
    }
}
