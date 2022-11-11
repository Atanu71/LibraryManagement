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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {



                string bname = txtName.Text;
                String bauthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                string pdate = dateTimePicker1.Text;

                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-VUODEC6;database=library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();

                cmd.CommandText = "insert into NewBook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();

                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
    private void BtnCancel_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("This will DELETE your Unsaved DATA", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        {
                this.Close();
        }

    }

}
          


     
     
}
