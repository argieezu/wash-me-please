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
    public partial class StaffRegisterForm : Form
    {
        public StaffRegisterForm()
        {
            InitializeComponent();
        }

        private void btnLoginNow_Click(object sender, EventArgs e)
        {
            StaffLoginForm StaffLogin = new StaffLoginForm();          
            this.Hide();
            StaffLogin.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
