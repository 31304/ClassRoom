using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Class_Room
{
    public partial class Form14 : Form
    {
        int id; string username; string code; string type; string filePath;
        public Form14(int id, string username, string code, string type, string filePath)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
            this.code = code;
            this.type = type;
            this.filePath = filePath;
            pdfViewer1.LoadFromFile(this.filePath);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pdfViewer1.CloseDocument();
            if (type == "1")
            {
                Form11 form11 = new Form11(id, username, code);
                form11.Size = this.Size;
                form11.Closed += (s, args) => this.Close();
                form11.Show();
                this.Hide();
            }
            else if (type == "2")
            {
                Form12 form12 = new Form12(id, username, code);
                form12.Size = this.Size;
                form12.Closed += (s, args) => this.Close();
                form12.Show();
                this.Hide();
            }
            else if (type == "3")
            {
                Form15 form15 = new Form15(id, username, code);
                form15.Size = this.Size;
                form15.Closed += (s, args) => this.Close();
                form15.Show();
                this.Hide();
            }
            else if (type == "4")
            {
                Form16 form16 = new Form16(id, username, code);
                form16.Size = this.Size;
                form16.Closed += (s, args) => this.Close();
                form16.Show();
                this.Hide();
            }
            else if (type == "5")
            {
                Form19 form19 = new Form19(id, username, code);
                form19.Size = this.Size;
                form19.Closed += (s, args) => this.Close();
                form19.Show();
                this.Hide();
            }
        }
    }
}
