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
           
        }
        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {

        } 
        private void buttonStaffBackToAdminOrStaff_Click(object sender, EventArgs e)
        {
            AdminOrStaff adminOrStaff = new AdminOrStaff();
            adminOrStaff.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
