﻿using System;
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

    public partial class plotwise_rm_rpt : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIRAJ-PC\SQLEXPRESS;Initial Catalog=AgroLogix;Integrated Security=True");

        public plotwise_rm_rpt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new DashBoard();
            f2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("view_plotrpt", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@fnumber", comboBox1.Text);
            adp.SelectCommand.Parameters.AddWithValue("@plotno", comboBox2.Text);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            dgrptview.DataSource=dt;
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
    }
}
