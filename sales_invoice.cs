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
    public partial class sales_invoice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");
        public sales_invoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void tb_dealername_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("view_dealer_on_id", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@dealerid", tb_dealerid.Text);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                tb_dealername.Text = (string)dt.Rows[0]["dealer_name"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_invoiceid_Enter(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("selectmax_salesinv", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            int a = ((int)dt.Rows[0]["inv"]+1);
            tb_invoiceid.Text = a.ToString();
        }

        private void cb_fieldno_Enter(object sender, EventArgs e)
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

        private void cb_plotno_Enter(object sender, EventArgs e)
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

        private void cb_croptype_Enter(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select_croptype", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@fnumber", cb_fieldno.Text);
            adp.SelectCommand.Parameters.AddWithValue("@plotno", cb_fieldno.Text);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_croptype.ValueMember = "crop_type";
            //cb1.DisplayMember = "name";
            cb_croptype.DataSource = dt;
        }

        private void tb_amount_Enter(object sender, EventArgs e)
        {

        }

        private void tb_price_TextChanged(object sender, EventArgs e)
        {
            decimal qty = decimal.Parse(tb_qty.Text);
            decimal price = decimal.Parse(tb_price.Text);

            decimal total = qty * price;
            tb_amount.Text = total.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("add_sales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@dealerid", tb_dealerid.Text);
            cmd.Parameters.AddWithValue("@dealer", tb_dealername.Text);
            cmd.Parameters.AddWithValue("@invoiceid", tb_invoiceid.Text);
            cmd.Parameters.AddWithValue("@fnumber", cb_fieldno.Text);
            cmd.Parameters.AddWithValue("@plotnumber", cb_plotno.Text);
            cmd.Parameters.AddWithValue("@crop", cb_croptype.Text);
            cmd.Parameters.AddWithValue("@qty", tb_qty.Text);
            cmd.Parameters.AddWithValue("@price", tb_price.Text);
            cmd.Parameters.AddWithValue("@amount", tb_amount.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            con.Close();

            
            tb_invoice_id.Text = tb_invoiceid.Text;
            tb_dealer_name.Text = "";
            tb_dealer_name.Text = tb_dealername.Text;

        }

        private void tb_invoice_id_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_sales", con);
            adp.SelectCommand.Parameters.AddWithValue("@invoiceid", tb_invoice_id.Text);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
           adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }

        private void tb_dealer_name_Enter(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adp1 = new SqlDataAdapter("view_dealer_name", con);
                adp1.SelectCommand.Parameters.AddWithValue("@invoiceid", tb_invoice_id.Text);
                adp1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt1 = new DataTable();
                con.Open();
                adp1.Fill(dt1);
                tb_dealer_name.Text = (string)dt1.Rows[0]["dealer_name"];
                con.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error");
                //Note Catch block is also getting executed while on try block
            }

        }

        private void tb_dealer_name_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_sales", con);
            adp.SelectCommand.Parameters.AddWithValue("@invoiceid", tb_invoice_id.Text);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Form f2 = new sales_log();
            f2.Show();
            this.Hide();
        }
    }
}
