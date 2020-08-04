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
    public partial class rm_Cat_master : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");
        public rm_Cat_master()
        {
            InitializeComponent();
            SqlDataAdapter adp = new SqlDataAdapter("view_category", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            category_grid.DataSource = dt;
            con.Close();

            SqlDataAdapter adp1 = new SqlDataAdapter("view_catproduct", con);
            adp1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt1 = new DataTable();
            con.Open();
            adp1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_category", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "rmcat";
            //comboBox1.DisplayMember = "rmcat";
            
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_unit", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            comboBox2.ValueMember = "unit";
            //cb1.DisplayMember = "name";
            comboBox2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("add_category", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@category", textBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();

               
                SqlDataAdapter adp = new SqlDataAdapter("view_category", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                category_grid.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("add_rmproduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@rmcat", comboBox1.Text);
                cmd.Parameters.AddWithValue("@rm_productname", textBox2.Text);
                cmd.Parameters.AddWithValue("@rm_unit", comboBox2.Text);
                cmd.Parameters.AddWithValue("@rm_price", textBox3.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();

                SqlDataAdapter adp1 = new SqlDataAdapter("view_catproduct", con);
                adp1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt1 = new DataTable();
                con.Open();
                adp1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
