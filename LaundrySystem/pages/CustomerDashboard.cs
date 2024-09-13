using LaundrySystem.auth_pages;
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

namespace LaundrySystem
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.Clear(panel3.BackColor);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            Dashboard dashboardForm = new Dashboard();


            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;
            lblNamePages.Text = "Dashboard";
            panel3.Controls.Clear();
            panel3.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            Account accountForm = new Account();

            accountForm.TopLevel = false;
            accountForm.FormBorderStyle = FormBorderStyle.None;
            accountForm.Dock = DockStyle.Fill;
            lblNamePages.Text = "Account";
            panel3.Controls.Clear();
            panel3.Controls.Add(accountForm);
            accountForm.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {

            Transaction transactionForm = new Transaction();


            transactionForm.TopLevel = false;
            transactionForm.FormBorderStyle = FormBorderStyle.None;
            transactionForm.Dock = DockStyle.Fill;
            lblNamePages.Text = "Transaction";
            panel3.Controls.Clear();
            panel3.Controls.Add(transactionForm);
            transactionForm.Show();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            Release releaseForm = new Release();


            releaseForm.TopLevel = false;
            releaseForm.FormBorderStyle = FormBorderStyle.None;
            releaseForm.Dock = DockStyle.Fill;
            lblNamePages.Text = "Release";
            panel3.Controls.Clear();
            panel3.Controls.Add(releaseForm);
            releaseForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category categoryForm = new Category();

            categoryForm.TopLevel = false;
            categoryForm.FormBorderStyle = FormBorderStyle.None;
            categoryForm.Dock = DockStyle.Fill;
            lblNamePages.Text = "Category";
            panel3.Controls.Clear();
            panel3.Controls.Add(categoryForm);
            categoryForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            CustomerLoginForm login = new CustomerLoginForm();
            login.Show();
        }

        private void upperPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNamePages_Click(object sender, EventArgs e)
        {

        }
    }
}
