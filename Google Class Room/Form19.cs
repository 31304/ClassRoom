using Spire.Pdf.Fields;
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
    public partial class Form19 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string filepath;

        private int id;
        private string username;
        private string code;
        public Form19(int id, string username, string code)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
            this.code = code;
            cn = new SqlConnection(dbcon.MyConnection());
            // (username, assignmentid, submitTime, submitDate, filepath)
            cn.Open();
            cm = new SqlCommand("select * from  submitAssignment where  assignmentid = @assignmentid ", cn);
            cm.Parameters.AddWithValue("@assignmentid", id);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            { 
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    string time = dr.GetString(3);
                    string date = dr.GetString(4);
                    int j= dr.GetInt32(0);
                    string pathoffile = dr.GetString(5);
                    string imagepath = "C:\\Users\\samii\\Downloads\\icons8-assignment-100.png";
                    Button button = new Button();
                    string tab = "     ";
                    button.Text = (name +  tab+tab+tab+tab+ time + tab + date).ToString();
                    button.TextAlign = ContentAlignment.MiddleRight;
                    button.Size = new Size(944, 101);
                    button.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                    button.BackColor = Color.Gray;
                    button.Tag = pathoffile as String; // Set the ID or name as the Tag
                    button.Click += Button_Click_Assignment1;        //button.Click += Button_Click;
                    button.Image = Image.FromFile(imagepath);
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    TextBox textbox = new TextBox();
                    textbox.Font = new Font("Segoe UI",  18, FontStyle.Regular);
                    textbox.Width = 200;
                    textbox.PlaceholderText = "Grade";
                    textbox.Tag = j;
                    textbox.TextChanged += textboxtext;
                    Button button2=new Button();
                    button2.Text = name;
                    button2.Click += Button_ClicK;
                    button2.Tag = j;
                    flowLayoutPanel1.Controls.Add(button);
                    flowLayoutPanel1.Controls.Add(textbox);
                    flowLayoutPanel1.Controls.Add(button2);
                }
            }
            cn.Close();
        }

        private void Button_ClicK(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            if (j == (int)button.Tag)
            {
                /*  cn.Open();
                  cm = new SqlCommand("DROP TABLE IF EXISTS grade", cn);
                  cm.ExecuteNonQuery();
                  cm = new SqlCommand("Create table grade (id int IDENTITY(1,1) primary key (id) , username varchar(50) foreign key(username) references systemUser(username) on delete cascade,  assignmentno int ,assignmentid int ,text varchar(30)  )", cn);
                  //cm.Parameters.AddWithValue("@assignmentid", id);
                  cm.ExecuteNonQuery();
                  cn.Close();*/

               
                    cn.Open();
                    cm = new SqlCommand("Update grade set text = @text where assignmentid = @assignmentid", cn);
                    cm.Parameters.AddWithValue("@assignmentid", j);
                    cm.Parameters.AddWithValue("@text", grade);
                    dr=cm.ExecuteReader();
                cn.Close() ;
                cn.Open();
                cm = new SqlCommand("Select * from grade where assignmentid = @assignmentid", cn);
                cm.Parameters.AddWithValue("@assignmentid", j);
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                    {
                        cn.Close();
                        button.Text = "Updated";
                    }
                    else
                    {
                        cn.Close ();
                        cn.Open();
                        cm = new SqlCommand(" Insert into grade (username, assignmentno,assignmentid,text) values (@username, @assignmentno,@assignmentid,@text) ", cn);
                        cm.Parameters.AddWithValue("@username", button.Text);
                        cm.Parameters.AddWithValue("@assignmentno", id);
                        cm.Parameters.AddWithValue("@assignmentid", j);
                        cm.Parameters.AddWithValue("@text", grade);
                        cm.ExecuteReader();
                        cn.Close();
                        button.Text = "Submitted";
                    }

            }
        }
        private String grade;
        private int j;
        private void textboxtext(object? sender, EventArgs e)
        {
            TextBox tex=sender as TextBox;
            grade = tex.Text;
            j = (int)tex.Tag;
        }

        private void Button_Click_Assignment1(object? sender, EventArgs e)
        {
            
            Button? button = sender as Button;
            Form14 form14 = new Form14(id,username,code,"5",button.Tag.ToString());
            form14.Size = this.Size;
            form14.Closed += (s, args) => this.Close();
            form14.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(id, username, code);
            form11.Size = this.Size;
            form11.Closed += (s, args) => this.Close();
            form11.Show();
            this.Hide();
        }
    }
}
