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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Google_Class_Room
{
    public partial class Form20 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private int id; private string username;private string code;
        public Form20(int id, string username, string code)
        {
            this.id = id;
            this.code = code;
            this.username = username;
            cn = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
            cn.Open();
            string query = "SELECT username, text FROM Grade WHERE assignmentno = @assignmentno ";
            SqlCommand command = new SqlCommand(query, cn);
            command.Parameters.AddWithValue("@assignmentno", id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11( id,  username, code);
            form11.Size = this.Size;
            form11.Closed += (s, args) => this.Close();
            form11.Show();
            this.Hide();
        }
    }
}
