using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_Software_Engineering
{
    class Login
    {

        private string uname;
        private string pwd;

        public string getUname()
        {
            return uname;
        }

        public void setUname(string uname)
        {
            this.uname = uname;
        }

        public string getPwd()
        {
            return pwd;
        }

        public void setPwd(string pwd)
        {
            this.pwd = pwd;
        }

        public bool arg(string uname, string pwd)
        {
            bool val;
            DatabaseConnection dbc = new DatabaseConnection();
            if (dbc.GetData("SELECT COUNT(*) FROM LOGIN WHERE ID='" + uname + "' AND PASSWORD ='" + pwd + "'") == "1")
            {
                return val = true;
            }
            else
            {
                return val = false;
            }

        }

    }
}
