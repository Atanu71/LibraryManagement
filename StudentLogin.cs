using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void txtstudentusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtstudentusername.Text == "Username")
            {
                txtstudentusername.Clear();
            }
        }

        private void txtstudentpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtstudentpassword.Text == "Password")
            {
                txtstudentpassword.Clear();
              
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VUODEC6 ; database=library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from studentTable where username = '" + txtstudentusername.Text + "' and pass ='" + txtstudentpassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();

                Student_Profile SP = new Student_Profile();
                SP.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtstudentusername.Clear();
            txtstudentpassword.Clear();

        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}
