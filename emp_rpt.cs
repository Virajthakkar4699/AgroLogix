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
    public partial class emp_rpt : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");
        public emp_rpt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void cb_employee_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_empmaster", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_employee.ValueMember = "empname";
            cb_employee.DataSource = dt;
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

        private void cb_plotno_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_plot", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@fieldno", cb_fieldno.Text); ;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_plotno.ValueMember = "plotid";
            //cb1.DisplayMember = "name";
            cb_plotno.DataSource = dt;
        }

        private void btn_view_emp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("view_rptempname", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@empname", cb_employee.Text);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                dg_empwise.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void brn_view_plot_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("view_empplotwiserpt", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@fieldno", cb_fieldno.Text);
                adp.SelectCommand.Parameters.AddWithValue("@plotno", cb_plotno.Text);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                dg_plotwise.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
