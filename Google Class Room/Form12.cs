using System.Data.SqlClient;

namespace Google_Class_Room
{
    public partial class Form12 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private int id;
        private string username;
        private string code;
        private string filepath;
        public Form12(int id, string username, string code)
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
            label1.Text = tittle;
            label2.Text = discription;
            button8.Text = tittle;
            cn.Close();

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
            Form14 form14 = new Form14(id, username, code, "2", filepath);
            form14.Size = this.Size;
            form14.Closed += (s, args) => this.Close();
            form14.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("Delete from ClassMaterial  where id = @id", cn);
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
            Form9 form9 = new Form9(code, username, "2", id);
            form9.Size = this.Size;
            form9.Closed += (s, args) => this.Close();
            form9.Show();
            this.Hide();
        }
    }
}
