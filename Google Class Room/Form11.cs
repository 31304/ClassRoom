using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Google_Class_Room
{
    public partial class Form11 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string filepath;
        private int id;
        private string username;
        private string code;
        public Form11(int id, string username, string code)
        {
            this.id = id;
            this.username = username;
            this.code = code;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
            cn.Open();
            cm = new SqlCommand("select * from Assingment where id = @id", cn);
            cm.Parameters.AddWithValue("@id", id);
            dr = cm.ExecuteReader();
            dr.Read();
            string tittle = dr.GetString(1);
            string discription = dr.GetString(2);
            string duedate = dr.GetString(3);
            filepath = dr.GetString(5);
            cn.Close();
            label1.Text = tittle;
            label2.Text = discription;
            label4.Text = duedate;
            button8.Text = tittle;
            label5.Visible = false; ;
            button17.Visible = false;
            dateTimePicker1.Visible = false;
            sql();
        }
        private void sql()
        {
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select * from AssignmentComment where assignmentid = @assignmentid ", cn);
            cm.Parameters.AddWithValue("@assignmentid ", id);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id1 = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    string comment = dr.GetString(3);
                    Label button = new Label();
                    string tab = "             ";
                    button.Text = name + tab + comment;
                    button.Size = new Size(1000, 101);
                    button.Font = new Font("Segoe UI", 15, FontStyle.Regular);
                    button.Tag = id; // Set the ID or name as the Tag
                                     //button.Click += Button_Click_Assignment1;        //button.Click += Button_Click;
                    Button button2 = new Button();
                    button2.Text = "Delete";
                    button2.Tag = id1;
                    button2.Click += Button2_Click;
                    flowLayoutPanel1.Controls.Add(button);
                    flowLayoutPanel1.Controls.Add(button2);

                }

            }
            cn.Close();
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            cn.Open();
            cm = new SqlCommand("Delete from AssignmentComment where id = @id", cn);
            cm.Parameters.AddWithValue("@id", (int)button.Tag);
            cm.ExecuteNonQuery();
            cn.Close();
            flowLayoutPanel1.Controls.Clear();
            sql();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, code);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(id, username, code, "1", filepath);
            form14.Size = this.Size;
            form14.Closed += (s, args) => this.Close();
            form14.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19(id, username, code);
            form19.Size = this.Size;
            form19.Closed += (s, args) => this.Close();
            form19.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("Delete from Assingment where id = @id", cn);
            cm.Parameters.AddWithValue("@id", id);
            cm.ExecuteNonQuery();
            cn.Close();
            Form7 form7 = new Form7(username, code);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(code, username, "2", id);
            form8.Size = this.Size;
            form8.Closed += (s, args) => this.Close();
            form8.Show();
            this.Hide();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string duedate = dateTimePicker1.Text.ToString();
            cn.Open();
            cm = new SqlCommand("update Assingment set date = @duedate where id = @id", cn);
            cm.Parameters.AddWithValue("@id", id);
            cm.Parameters.AddWithValue("@duedate", duedate);
            cm.ExecuteNonQuery();
            cn.Close();
            label4.Text = duedate;
            label5.Visible = false;
            button17.Visible = false;
            dateTimePicker1.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            button17.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("insert into AssignmentComment (username ,assignmentid  ,text) values (@username,@assignmentid,@text)", cn);
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@assignmentid ", id);
            cm.Parameters.AddWithValue("@text ", textBox1.Text);
            dr = cm.ExecuteReader();
            cn.Close();
            cn.Open();
            flowLayoutPanel1.Controls.Clear();
            sql();


        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20( id, username, code);
            form20.Size = this.Size;
            form20.Closed += (s, args) => this.Close();
            form20.Show();
            this.Hide();
        }
    }
}
