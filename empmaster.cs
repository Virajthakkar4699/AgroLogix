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
    public partial class empmaster : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");
        public empmaster()
        {
            InitializeComponent();

            SqlDataAdapter adp = new SqlDataAdapter("view_empmaster", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            dgview.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void empmaster_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("add_emp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empname", textBox1.Text);
                cmd.Parameters.AddWithValue("@empphone", textBox2.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();

                SqlDataAdapter adp = new SqlDataAdapter("view_empmaster", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                dgview.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
