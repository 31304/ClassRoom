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
    public partial class Form13 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private int id;
        private string username;
        private string code;
        public Form13(int id, string username, string code)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            this.id = id;
            this.username = username;
            this.code = code;
            InitializeComponent();
            cn.Open();
            cm = new SqlCommand("select * from  Announcement where id = @id", cn);
            cm.Parameters.AddWithValue("@id", id);
            dr = cm.ExecuteReader();
            dr.Read();
            string tittle = dr.GetString(1);
            string discription = dr.GetString(2);
            cn.Close();
            label1.Text = tittle;
            label2.Text = discription;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, code);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, code);
            form7.Size = this.Size;
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("Delete from Announcement where id = @id", cn);
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
            Form10 form10 = new Form10(code, username, "2", id);
            form10.Size = this.Size;
            form10.Closed += (s, args) => this.Close();
            form10.Show();
            this.Hide();
        }
    }
}
