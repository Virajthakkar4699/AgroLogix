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
    public partial class fieldmaster : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");
        public fieldmaster()
        {
            InitializeComponent();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("sp_fieldview", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                fieldgrid.DataSource = dt;
                con.Close();

                SqlDataAdapter adp1 = new SqlDataAdapter("sp_plotview", con);
                adp1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt1 = new DataTable();
                con.Open();
                adp1.Fill(dt1);
                plotgrid.DataSource = dt1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

        private void btnfieldview_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("sp_fieldview", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                fieldgrid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_plotview_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adp1 = new SqlDataAdapter("sp_plotview", con);
                adp1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt1 = new DataTable();
                con.Open();
                adp1.Fill(dt1);
                plotgrid.DataSource = dt1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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

        private void btn_fieldadd_Click(object sender, EventArgs e)
        {
            //sp_addfield
            try
            {
                SqlCommand cmd = new SqlCommand("sp_addfield", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fieldno", tb_fieldno.Text);
                cmd.Parameters.AddWithValue("@fieldarea", tb_fieldarea.Text);
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

        private void btn_plotadd_Click(object sender, EventArgs e)
        {
            //String s = cb1.SelectedValue.ToString();
            //// MessageBox.Show(s);
            //tb_Name.Text = s;

            try
            {
                SqlCommand cmd = new SqlCommand("sp_addplot", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@plotid", tb_plotno.Text);

                String fieldno = cb_fieldno.SelectedValue.ToString();
                cmd.Parameters.AddWithValue("@f_number", fieldno);

                cmd.Parameters.AddWithValue("@plotarea", tb_plotarea.Text);
                cmd.Parameters.AddWithValue("@partnername", tb_partner.Text);

                String crop_type = cb_croptype.SelectedValue.ToString();
                cmd.Parameters.AddWithValue("@croptype", crop_type);

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

        private void cb_croptype_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
