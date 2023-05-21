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

namespace Google_Class_Room
{
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public Form2()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text) || (string.IsNullOrEmpty(comboBox1.Text)) || (string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    label1.Visible = true;
                }
                if ((string.IsNullOrEmpty(comboBox1.Text)))
                {
                    label2.Visible = true;
                }
                if ((string.IsNullOrEmpty(textBox1.Text)))
                {
                    label3.Visible = true;
                }
                if ((string.IsNullOrEmpty(textBox2.Text)))
                {
                    label4.Visible = true;
                }
            }
            else if (textBox1.Text != textBox2.Text)
            {
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {


                    cn.Open();
                    cm = new SqlCommand("Select * from systemUser where username= @Username", cn);
                    cm.Parameters.AddWithValue("@Username", textBox.Text);
                    dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        label7.Visible = true;
                    }
                    else
                    {
                        cn.Close();
                        cn.Open();
                        string Username = textBox.Text;
                        string password = textBox1.Text;
                        string role = comboBox1.Text;
                        cm = new SqlCommand("insert into systemUser (username,password,role) values (@Username , @password,@role) ", cn);
                        cm.Parameters.AddWithValue("@username", Username);
                        cm.Parameters.AddWithValue("@password", password);
                        cm.Parameters.AddWithValue("@role", role);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        Form1 form1 = new Form1();
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                        this.Hide();
                    }
                    cn.Close();
              
                
              /*  catch
                {
                    cm = new SqlCommand("DROP TABLE IF EXISTS systemUser", cn);
                    cm.ExecuteNonQuery();
                    cm = new SqlCommand("create table systemUser (username varchar(50) primary key(username),password varchar(20),role varchar(14))", cn);
                    cm.ExecuteNonQuery();
                }*/
            }
        }
        private void visibilityFalse()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            visibilityFalse();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            visibilityFalse();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibilityFalse();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            visibilityFalse();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            visibilityFalse();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
    }
}
