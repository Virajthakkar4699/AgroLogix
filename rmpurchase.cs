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
    public partial class rmpurchase : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");
        public rmpurchase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cb_rmcategory_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_category", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_rmcategory.DataSource = dt;
            cb_rmcategory.ValueMember = "rmcat";
            //comboBox1.DisplayMember = "rmcat";

        }

        private void tb_vendor_name_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cb_rmproduct_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_rmproduct", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@category", cb_rmcategory.Text);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            cb_rmproduct.ValueMember = "rm_productname";
            //cb1.DisplayMember = "name";
            cb_rmproduct.DataSource = dt;
        }

        private void tb_qty_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_productunit", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@product", cb_rmproduct.Text);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            lb_qty.Text = (string)dt.Rows[0]["rm_unit"];
            lb_price.Text = (string)dt.Rows[0]["price"].ToString();
            //cb1.DisplayMember = "name";
            //cb_rmproduct.DataSource = dt;
        }

        private void tb_amount_MouseClick(object sender, MouseEventArgs e)
        {
            decimal qty = decimal.Parse(tb_qty.Text);
            //MessageBox.Show(value.ToString());
            decimal price = decimal.Parse(lb_price.Text);
            //MessageBox.Show(price.ToString());
            decimal amount = qty * price;
            tb_amount.Text = amount.ToString();
        }

        private void tb_vendorname_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("view_vendor_on_id", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@vendorid", tb_vendorid.Text);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                tb_vendorname.Text = (string)dt.Rows[0]["vendor_name"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Vendor Found");
            }
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("" + dateTimePicker1.Value);
            SqlCommand cmd = new SqlCommand("add_rmpurchase", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@vendorid", tb_vendorid.Text);
            cmd.Parameters.AddWithValue("@vendor_billno", tb_invoiceid.Text);
            cmd.Parameters.AddWithValue("@vendorname", tb_vendorname.Text);
            cmd.Parameters.AddWithValue("@rmcat", cb_rmcategory.Text);
            cmd.Parameters.AddWithValue("@rm_productname", cb_rmproduct.Text);
            cmd.Parameters.AddWithValue("@rm_unit",lb_qty.Text);
            cmd.Parameters.AddWithValue("@qty", tb_qty.Text);
            cmd.Parameters.AddWithValue("@amount", tb_amount.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            con.Close();

            tb_invoice_id.Text = tb_invoiceid.Text;
            tb_vendor_name.Text = "";
            tb_vendor_name.Text = tb_vendorname.Text;


        }

        private void tb_vendor_name_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_rmpurchase", con);
            adp.SelectCommand.Parameters.AddWithValue("@vendorbillno", tb_invoice_id.Text);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void tb_invoice_id_TextChanged(object sender, EventArgs e)
        {
           
            SqlDataAdapter adp = new SqlDataAdapter("view_rmpurchase", con);
            adp.SelectCommand.Parameters.AddWithValue("@vendorbillno", tb_invoice_id.Text);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            65con.Open();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

           
        }

        private void tb_vendor_name_Enter(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adp1 = new SqlDataAdapter("view_vendorname", con);
                adp1.SelectCommand.Parameters.AddWithValue("@vendorbillno", tb_invoice_id.Text);
                adp1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt1 = new DataTable();
                con.Open();
                adp1.Fill(dt1);
                tb_vendor_name.Text = (string)dt1.Rows[0]["vendorname"];
                con.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error");
               //Note Catch block is also getting executed while on try block
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Form f2 = new rm_purchaselog();
            f2.Show();
            this.Hide();
        }
    }
}
