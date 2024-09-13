using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem.auth_pages
{
    public partial class CustomerRegisterForm : Form
    {
        public CustomerRegisterForm()
        {
            InitializeComponent();
        }

        private void btnLoginNow_Click(object sender, EventArgs e)
        {
            CustomerLoginForm ins = new CustomerLoginForm();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
