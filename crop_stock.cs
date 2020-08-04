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
    public partial class crop_stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");
        public crop_stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();

        }

        private void cb_fieldno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_fieldno_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("sp_select_fieldno", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_fieldno.ValueMember = "f_number";
            //cb1.DisplayMember = "name";
            cb_fieldno.DataSource = dt;
        }

        private void cb_croptype_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("sp_select_croptype", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_croptype.ValueMember = "crop_name";
            //cb1.DisplayMember = "name";
            cb_croptype.DataSource = dt;
        }

        private void cb_plotno_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_plot", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@fieldno", cb_fieldno.Text);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_plotno.ValueMember = "plotid";
            //cb1.DisplayMember = "name";
            cb_plotno.DataSource = dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("add_cropstock", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fieldno", cb_fieldno.Text);
            cmd.Parameters.AddWithValue("@plotno", cb_plotno.Text);
            cmd.Parameters.AddWithValue("@croptype", cb_croptype.Text);
            cmd.Parameters.AddWithValue("@qty", tb_qty.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            con.Close();
        }
    }
}
