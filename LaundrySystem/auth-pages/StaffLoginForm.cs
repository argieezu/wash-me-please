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
    public partial class StaffLoginForm : Form
    {
        public StaffLoginForm()
        {
            InitializeComponent();
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            StaffDashboard Staff = new StaffDashboard();
            this.Hide();
            Staff.ShowDialog();
        }

        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {

        }

   

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            StaffRegisterForm StaffRegister = new StaffRegisterForm();
            this.Hide();
            StaffRegister.ShowDialog();

        }
    }
}
