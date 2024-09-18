using System;
using System.Data;
using System.Windows.Forms;
using LaundrySystem.BackEnd; 

namespace LaundrySystem.AdminPages
{
    public partial class CustomerFormAdmin : Form
    {
        private MySqlProcedure mySqlProcedure;
        private System.Windows.Forms.Timer refreshTimer;

        public CustomerFormAdmin()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void CustomerFormAdmin_Load(object sender, EventArgs e)
        {
            mySqlProcedure = new MySqlProcedure();

            if (mySqlProcedure.fncConnectToDatabase())
            {
                // Fetch all customers and display in the DataGridView
                DisplayAllCustomers();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 3000;
            refreshTimer.Tick += new EventHandler(OnTimerTick);
            refreshTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            DisplayAllCustomers();
        }

        private void DisplayAllCustomers()
        {
            DataTable customerData = mySqlProcedure.GetAllCustomers();

            if (customerData != null && customerData.Rows.Count > 0)
            {
                dataGridViewDisplayCustomer.DataSource = customerData;
            }
            else
            {
                dataGridViewDisplayCustomer.DataSource = null;
            }
        }

        private void btnNewCustomerAdmin_Click(object sender, EventArgs e)
        {
            AddingCustomerForm addingcustomer = new AddingCustomerForm();
            addingcustomer.ShowDialog();
        }

        private void dataGridViewDisplayCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
           
        }
    }
}
