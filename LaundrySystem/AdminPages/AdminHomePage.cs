using LaundrySystem.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem.AdminPages
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {
            AdminDashboardForm dashboardForm = new AdminDashboardForm();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;
            lblHomePageAdmin.Text = "Dashboard";
            panel3.Controls.Clear();
            panel3.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }

        private void btnCustomerAdmin_Click(object sender, EventArgs e)
        {
            CustomerFormAdmin customerForm = new CustomerFormAdmin();
            customerForm.TopLevel = false;
            customerForm.FormBorderStyle = FormBorderStyle.None;
            customerForm.Dock = DockStyle.Fill;
            lblHomePageAdmin.Text = "Customer";
            panel3.Controls.Clear();
            panel3.Controls.Add(customerForm);
            customerForm.Show();
        }

        private void btnGarmentsAdmin_Click(object sender, EventArgs e)
        {
            GarmentsFormAdmin garmentsForm = new GarmentsFormAdmin();
            garmentsForm.TopLevel = false;
            garmentsForm.FormBorderStyle = FormBorderStyle.None;
            garmentsForm.Dock = DockStyle.Fill;
            lblHomePageAdmin.Text = "Garments";
            panel3.Controls.Clear();
            panel3.Controls.Add(garmentsForm);
            garmentsForm.Show();

        }

        private void btnTransactionAdmin_Click(object sender, EventArgs e)
        {
            TransactionFormAdmin transactionForm = new TransactionFormAdmin();
            transactionForm.TopLevel = false;
            transactionForm.FormBorderStyle = FormBorderStyle.None;
            transactionForm.Dock = DockStyle.Fill;
            lblHomePageAdmin.Text = "Transaction";
            panel3.Controls.Clear();
            panel3.Controls.Add(transactionForm);
            transactionForm.Show();
        }

        private void btnStaffAdmin_Click(object sender, EventArgs e)
        {
            StaffAccountForm staffAccountForm = new StaffAccountForm();
            staffAccountForm.TopLevel = false;
            staffAccountForm.FormBorderStyle = FormBorderStyle.None;
            staffAccountForm.Dock = DockStyle.Fill;
            lblHomePageAdmin.Text = "Staff";
            panel3.Controls.Clear();
            panel3.Controls.Add(staffAccountForm);
            staffAccountForm.Show();
        }
    }
}
