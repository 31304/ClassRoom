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
    public partial class Form9 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private String ClassCode;
        private String filePath;
        private string username;
        private string type;
        private int id;
        public Form9(string classCode, string username, string type, int id)
        {
            InitializeComponent();
            this.id = id;
            this.type = type;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            ClassCode = classCode;
            this.username = username;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            
            string title = textBox1.Text;
            string discription = textBox2.Text;
            if (type == "1")
            {
                /*cn.Open();
                cm = new SqlCommand("DROP TABLE IF EXISTS ClassMaterial", cn);
                cm.ExecuteNonQuery();
                cm = new SqlCommand("create table ClassMaterial (id int IDENTITY(1,1) primary key(id), title varchar(100),discription varchar(500), code varchar(50) foreign key(code) references ClassRoom(code) on delete cascade,filepath varchar(300))", cn);
                cm.ExecuteReader();
                cn.Close();*/
                cn.Open();
                cm = new SqlCommand("Insert into ClassMaterial (title,discription,code,filepath) values (@title,@discription,@code,@filepath)", cn);
                cm.Parameters.AddWithValue("@title", title);
                cm.Parameters.AddWithValue("@discription", discription);
                cm.Parameters.AddWithValue("@code", ClassCode);
                cm.Parameters.AddWithValue("@filepath", filePath);
                cm.ExecuteNonQuery();
                cn.Close();
                Form7 form7 = new Form7(username, ClassCode);
                form7.Size = this.Size;
                form7.Closed += (s, args) => this.Close();
                form7.Show();
                this.Hide();
            }
            else if (type == "2")
            {
                cn.Open();
                cm = new SqlCommand("update ClassMaterial set title = @title , discription = @discription, code = @code ,filepath = @filepath where id = @id", cn);
                cm.Parameters.AddWithValue("@title", title);
                cm.Parameters.AddWithValue("@discription", discription);
                cm.Parameters.AddWithValue("@code", ClassCode);
                cm.Parameters.AddWithValue("@filepath", filePath);
                cm.Parameters.AddWithValue("@id", id);
                cm.ExecuteNonQuery();
                cn.Close();
                Form12 form12 = new Form12(id, username, ClassCode);
                form12.Size = this.Size;
                form12.Closed += (s, args) => this.Close();
                form12.Show();
                this.Hide();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, ClassCode);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }
    }

}
