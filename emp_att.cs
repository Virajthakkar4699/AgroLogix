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
    public partial class emp_att : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");

        public emp_att()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emp_att_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f2 = new emp_rpt();
            f2.Show();
            this.Hide();

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_empmaster", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox1.ValueMember = "empname";
            comboBox1.DataSource = dt;
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("sp_select_fieldno", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox2.ValueMember = "f_number";
            //cb1.DisplayMember = "name";
            comboBox2.DataSource = dt;
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_plot", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@fieldno", comboBox2.Text); ;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox3.ValueMember = "plotid";
            //cb1.DisplayMember = "name";
            comboBox3.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("add_att", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ename", comboBox1.Text);          
                cmd.Parameters.AddWithValue("@fieldno", comboBox2.Text);
                cmd.Parameters.AddWithValue("@plotno", comboBox3.Text);
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
