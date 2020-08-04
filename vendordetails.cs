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

namespace AgroLogix
{
    public partial class vendordetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");

        public vendordetails()
        {
            InitializeComponent();
            // MessageBox.Show("Viraj");
            SqlDataAdapter adp = new SqlDataAdapter("view_vendor", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void vendordetails_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello Viraj");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("add_vendor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vname", tb_vendorname.Text);
                cmd.Parameters.AddWithValue("@vcity", tb_vendorcity.Text);
                cmd.Parameters.AddWithValue("@vphone", tb_vendorphone.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();

                SqlDataAdapter adp = new SqlDataAdapter("view_vendor", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
