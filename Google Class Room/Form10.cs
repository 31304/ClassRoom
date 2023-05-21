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
    public partial class Form10 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private String ClassCode;
        private string username;
        private string type;
        private int id;
        public Form10(string classCode, string username,string type,int id)
        {
            this.id= id;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
            ClassCode = classCode;
            this.username = username;
            this.type = type;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            string title = textBox1.Text;
            string discription = textBox2.Text;
           if(type=="1")
            {
                /* cn.Open();
               cm = new SqlCommand("DROP TABLE IF EXISTS Announcement", cn);
               cm.ExecuteNonQuery();
               cm = new SqlCommand("create table Announcement (id int IDENTITY(1,1) primary key(id), title varchar(100), discription varchar(500),code varchar(50) foreign key(code) references ClassRoom(code) on delete cascade)", cn);
               dr = cm.ExecuteReader();
               cn.Close();*/
                cn.Open();
                cm = new SqlCommand("Insert into Announcement (title,discription,code) values (@title,@discription,@code)", cn);
                cm.Parameters.AddWithValue("@title", title);
                cm.Parameters.AddWithValue("@discription", discription);
                cm.Parameters.AddWithValue("@code", ClassCode);
                cm.ExecuteNonQuery();
                Form7 form7 = new Form7(username, ClassCode);
                form7.Size = this.Size;
                form7.Closed += (s, args) => this.Close();
                form7.Show();
                this.Hide();
            }
           else if(type=="2") {
                cn.Open();
                cm = new SqlCommand("update Announcement set title = @title , discription = @discription, code = @code  where id = @id", cn);
                cm.Parameters.AddWithValue("@title", title);
                cm.Parameters.AddWithValue("@discription", discription);
                cm.Parameters.AddWithValue("@code", ClassCode);
                cm.Parameters.AddWithValue("@id", id);
                cm.ExecuteNonQuery();
                cn.Close();
                Form13 form13 = new Form13(id, username, ClassCode);
                form13.Size = this.Size;
                form13.Closed += (s, args) => this.Close();
                form13.Show();
                this.Hide();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, ClassCode);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, ClassCode);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }
    }
}
