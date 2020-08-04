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
    public partial class rmplotwiseinput : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");

        public rmplotwiseinput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("sp_select_fieldno", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox1.ValueMember = "f_number";
            //cb1.DisplayMember = "name";
            comboBox1.DataSource = dt;
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_plot", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@fieldno", comboBox1.Text); ;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox2.ValueMember = "plotid";
            //cb1.DisplayMember = "name";
            comboBox2.DataSource = dt;
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_category", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox3.DataSource = dt;
            comboBox3.ValueMember = "rmcat";
            //comboBox1.DisplayMember = "rmcat";
        }

        private void comboBox4_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_rmproduct", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@category", comboBox3.Text);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox4.ValueMember = "rm_productname";
            //cb1.DisplayMember = "name";
            comboBox4.DataSource = dt;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_productunit", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@product", comboBox4.Text);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            lb_unit.Text = (string)dt.Rows[0]["rm_unit"];
            //cb1.DisplayMember = "name";
            //cb_rmproduct.DataSource = dt;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("add_plotinput", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fnumber", comboBox1.Text);
                cmd.Parameters.AddWithValue("@plotno", comboBox2.Text);
                cmd.Parameters.AddWithValue("@category", comboBox3.Text);
                cmd.Parameters.AddWithValue("@productname", comboBox4.Text);
                cmd.Parameters.AddWithValue("@qty", textBox1.Text);
                cmd.Parameters.AddWithValue("@unit", lb_unit.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
