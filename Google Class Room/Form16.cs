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
    public partial class Form16 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private int id;
        private string username;
        private string code;
        private string filepath;
        public Form16(int id, string username, string code)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            this.id = id;
            this.username = username;
            this.code = code;
            InitializeComponent();
            cn.Open();
            cm = new SqlCommand("select * from  ClassMaterial where id = @id", cn);
            cm.Parameters.AddWithValue("@id", id);
            dr = cm.ExecuteReader();
            dr.Read();
            string tittle = dr.GetString(1);
            string discription = dr.GetString(2);
            filepath = dr.GetString(4);
            cn.Close();
            label1.Text = tittle;
            label2.Text = discription;
            button8.Text = tittle;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(id, username, code, "4", filepath);
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
    }
}
