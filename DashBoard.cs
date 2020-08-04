using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLogix
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Login();
            f2.Show();
            this.Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new empmaster();
            f2.Show();
            this.Hide();
        }

        private void fieldMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new fieldmaster();
            f2.Show();
            this.Hide();
        }

        private void rMCategoryMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new rm_Cat_master();
            f2.Show();
            this.Hide();
        }

        private void inputPlotWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new rmplotwiseinput();
            f2.Show();
            this.Hide();
        }

        private void cropMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new cropmaster();
            f2.Show();
            this.Hide();
        }

        private void cropStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new crop_stock();
            f2.Show();
            this.Hide();
        }

        private void attendanceMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new emp_att();
            f2.Show();
            this.Hide();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new emp_rpt();
            f2.Show();
            this.Hide();
        }

        private void rawMaterialPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new rmpurchase();
            f2.Show();
            this.Hide();
        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new sales_invoice();
            f2.Show();
            this.Hide();
        }

        private void vendorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new vendordetails();
            f2.Show();
            this.Hide();
        }

        private void dealerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new dealer_details();
            f2.Show();
            this.Hide();
        }

        private void unitMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new unit_master();
            f2.Show();
            this.Hide();
        }

        private void plotReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form d2 = new plotwise_rm_rpt();
            d2.Show();
            this.Hide();
        }
    }
}
