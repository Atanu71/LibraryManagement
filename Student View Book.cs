
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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =DESKTOP-VUODEC6;database=library; integrated security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =DESKTOP-VUODEC6;database=library; integrated security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where bid=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtbName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString(); ;
            txtpDate.Text = ds.Tables[0].Rows[0][4].ToString(); ;
            txtprice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtquan.Text = ds.Tables[0].Rows[0][6].ToString();

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtbName.Text != "")
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "data source =DESKTOP-VUODEC6;database=library; integrated security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where bName LIKE '" + txtbName.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "data source =DESKTOP-VUODEC6;database=library; integrated security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where bid=" + bid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtbookname.Clear();
            panel2.Visible = false;

        }

        
    }
}