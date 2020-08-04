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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;

            if (user == "admin" && pass == "admin")
            {
                Form f2 = new DashBoard();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Username and Password");
            }
        }
    }
}
