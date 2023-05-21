using iTextSharp.text.pdf.qrcode;
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
    public partial class Form8 : Form
    {
        private string filePath;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private string classCode;
        private string username;
        private string type;
        private int id;
        public Form8(string classCode, string username,string type,int id)
        {
            this.id = id;
            this.classCode = classCode;
            this.username = username;
            this.type = type;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            InitializeComponent();
            this.classCode = classCode;
            this.username = username;
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

        private void button9_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string discription = textBox2.Text;
            string duedate = dateTimePicker1.Text;
            if (type=="1" )
            {
                /*cn.Open();
              cm = new SqlCommand("DROP TABLE IF EXISTS Assingment", cn);
              cm.ExecuteNonQuery();
              cm = new SqlCommand("create table Assingment (id int IDENTITY(1,1) primary key(id), title varchar(100),discription varchar(500),date varchar(50), code varchar(50) foreign key(code) references ClassRoom(code) on delete cascade,filepath varchar(300))", cn);
              dr = cm.ExecuteReader();
              cn.Close();*/
                cn.Open();
                cm = new SqlCommand("Insert into Assingment (title,discription,date,code,filepath) values (@title,@discription,@date,@code,@filepath)", cn);
                cm.Parameters.AddWithValue("@title", title);
                cm.Parameters.AddWithValue("@discription", discription);
                cm.Parameters.AddWithValue("@date", duedate);
                cm.Parameters.AddWithValue("@code", classCode);
                cm.Parameters.AddWithValue("@filepath", filePath);
                cm.ExecuteNonQuery();
                Form7 form7 = new Form7(username, classCode);
                form7.Size = this.Size;
                form7.Closed += (s, args) => this.Close();
                form7.Show();
                this.Hide();
            }
            else if(type=="2" )
            {
                cn.Open();
                cm = new SqlCommand("update Assingment set title = @title , discription = @discription , date = @date, code = @code ,filepath = @filepath where id = @id", cn);
                cm.Parameters.AddWithValue("@title", title);
                cm.Parameters.AddWithValue("@discription", discription);
                cm.Parameters.AddWithValue("@date", duedate);
                cm.Parameters.AddWithValue("@code", classCode);
                cm.Parameters.AddWithValue("@filepath", filePath);
                cm.Parameters.AddWithValue("@id", id);
                cm.ExecuteNonQuery();
                Form11 form11 = new Form11(id,username, classCode);
                form11.Size = this.Size;
                form11.Closed += (s, args) => this.Close();
                form11.Show();
                this.Hide();
            }
            
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, classCode);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }
    }
}
