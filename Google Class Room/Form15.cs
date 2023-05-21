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
    public partial class Form15 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string filepath;
        private int id;
        private string username;
        private string code;
        public Form15(int id, string username, string code)
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
            label5.Visible = false;
            cn.Open();
            cm = new SqlCommand(" select * from grade where username=@username and assignmentno = @assignmentno", cn);
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@assignmentno", id);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                string g = dr.GetString(4);
                label5.Visible = true;
                label5.Text = g;
            }
            cn.Close();
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(id, username, code, "3", filepath);
            form14.Size = this.Size;
            form14.Closed += (s, args) => this.Close();
            form14.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18(username, code);
            form18.Size = this.Size;
            form18.Closed += (s, args) => this.Close();
            form18.Show();
            this.Hide();
        }
        private string pathoffile;
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathoffile = openFileDialog.FileName;

            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            /* cn.Open();
             cm = new SqlCommand("DROP TABLE IF EXISTS submitAssignment", cn);
             cm.ExecuteNonQuery();
             cm = new SqlCommand("Create table submitAssignment (id int IDENTITY(1,1) primary key(id), username varchar(50) foreign key(username) references systemUser(username) on delete cascade, assignmentid int foreign key(assignmentid) references Assingment(id)on delete cascade,submitTime varchar(50), submitDate varchar(50),filepath varchar(400)  )", cn);
             dr = cm.ExecuteReader();
             cn.Close();*/
            cn.Open();
            cm = new SqlCommand("insert into submitAssignment(username,assignmentid,submitTime,submitDate,filepath ) values (@username,@assignmentid,@submitTime,@submitDate,@filepath )", cn);
            DateTime currentTime = DateTime.Now;
            string currentTimeString = currentTime.ToString("hh:mm:ss tt");
            DateTime currentDate = DateTime.Now;
            string currentDateString = currentDate.ToString("yyyy-MM-dd");
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@assignmentid", id);
            cm.Parameters.AddWithValue("@submitTime", currentTimeString);
            cm.Parameters.AddWithValue("@submitDate", currentDateString);
            cm.Parameters.AddWithValue("@filepath", pathoffile);
            cm.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            cm = new SqlCommand(" select * from grade where username=@username and assignmentno = @assignmentno", cn);
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@assignmentno", id);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                string g = dr.GetString(4);
                label5.Visible = true;
                label5.Text = g;
            }
            cn.Close();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            /* cn.Open();
             cm = new SqlCommand("DROP TABLE IF EXISTS AssignmentComment", cn);
             cm.ExecuteNonQuery();
             cm = new SqlCommand("Create table  AssignmentComment(id int IDENTITY(1,1) primary key(id), username varchar(50) foreign key(username) references systemUser(username) on delete cascade, assignmentid int foreign key(assignmentid) references Assingment(id)on delete cascade ,  text varchar(500) )", cn);
             dr = cm.ExecuteReader();
             cn.Close();*/
            cn.Open();
            cm = new SqlCommand("insert into AssignmentComment (username ,assignmentid  ,text) values (@username,@assignmentid,@text)", cn);
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@assignmentid ", id);
            cm.Parameters.AddWithValue("@text ", textBox1.Text);
            dr = cm.ExecuteReader();
            cn.Close();
            cn.Open();
            string comment = textBox1.Text;
            Label button = new Label();
            string tab = "             ";
            button.Text = username + tab + comment;
            button.Size = new Size(944, 101);
            button.Font = new Font("Segoe UI", 15, FontStyle.Regular);
            button.Tag = id; // Set the ID or name as the Tag
                             //button.Click += Button_Click_Assignment1;        //button.Click += Button_Click;
            flowLayoutPanel1.Controls.Add(button);


        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("select * from AssignmentComment", cn);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string username = dr.GetString(1);
                    string comment = dr.GetString(3);
                    Label button = new Label();
                    string tab = "             ";
                    button.Text = username + tab + comment;
                    button.Size = new Size(944, 101);
                    button.Font = new Font("Segoe UI", 15, FontStyle.Regular);
                    button.Tag = id; // Set the ID or name as the Tag
                                     //button.Click += Button_Click_Assignment1;        //button.Click += Button_Click;
                    flowLayoutPanel1.Controls.Add(button);
                }

            }
            cn.Close();
        }
    }
}
