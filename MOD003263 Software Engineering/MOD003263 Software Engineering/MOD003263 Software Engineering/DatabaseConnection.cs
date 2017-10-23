using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MOD003263_Software_Engineering
{
    class DatabaseConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + "\\MOD003263SEDB.mdf;Integrated Security=True;Connect Timeout=30;");
        //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LOGIN WHERE USERNAME='" + uname.Text + "' AND PASSWORD ='" + pwd.Text + "'", con);
        //DataTable dt = new DataTable();

        public string GetData(string statement)
        {
            SqlDataAdapter sda = new SqlDataAdapter(statement,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

    }
}
