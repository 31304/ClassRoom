using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System;
using System.Data.OleDb;

namespace Google_Class_Room
{
    internal class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
        public string MyConnection()
        {

            con = @"Data Source= DESKTOP-CP6JSPV\SQLEXPRESS; Initial Catalog=Lab11; Integrated Security = True";
            return con;
        }
    }
}
