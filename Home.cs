using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnStudentlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin SL = new StudentLogin();
            SL.Show();
        }

        private void btnLibrarianlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            this.Hide();
            About ab = new About();
            ab.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
