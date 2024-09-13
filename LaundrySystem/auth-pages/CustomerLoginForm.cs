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
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            CustomerDashboard ins = new CustomerDashboard();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {

        }

   

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            CustomerRegisterForm ins = new CustomerRegisterForm();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();

        }
    }
}
