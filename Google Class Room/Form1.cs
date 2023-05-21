using System.Data.Common;
using System.Drawing.Drawing2D;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;

namespace Google_Class_Room
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            textBox.KeyPress += textBox1_KeyPress;
            textBox1.KeyPress += textBox1_KeyPress;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the default handling of the Enter key

                // Move focus to the next control
                Control currentControl = (Control)sender;
                SelectNextControl(currentControl, true, true, true, true);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox.Text) || (string.IsNullOrEmpty(textBox1.Text)))
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    label2.Visible = true;
                }
                if ((string.IsNullOrEmpty(textBox1.Text)))
                {
                    label3.Visible = true;
                }
            }
            else
            {
                cn.Open();
                cm = new SqlCommand("Select * from systemUser where username= @Username and Password = @Password", cn);
                cm.Parameters.AddWithValue("@Username", textBox.Text);
                cm.Parameters.AddWithValue("@Password", textBox1.Text);
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string username = dr.GetString(0);
                        string column1Value = dr.GetString(2);
                        if (column1Value == "Teacher"){
                            Form3 form3 = new Form3(username,"You are Login Sucessfully!");
                            form3.Closed += (s, args) => this.Close();
                            form3.Show();
                            this.Hide();
                        }
                        else if(column1Value == "Student"){
                            Form6 form6 = new Form6(username, "You are Login Sucessfully!");
                            form6.Closed += (s, args) => this.Close();
                            form6.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    label7.Visible = true;
                    label1.Visible = true;
                }
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void visibilityData()
        {
            label2.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            label7.Visible = false;
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            visibilityData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            visibilityData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visibilityData();
        }

        ~Form1()
        {

        }
    }
}