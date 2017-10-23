using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD003263_Software_Engineering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DatabaseConnection dbc = new DatabaseConnection();
            //MessageBox.Show(dbc.GetData("SELECT * FROM LOGIN"));
            Login lg = new Login();

            if(lg.arg(uname.Text,pwd.Text) == true)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Please check your username and password again !!!");
            }

        }
    }
}
