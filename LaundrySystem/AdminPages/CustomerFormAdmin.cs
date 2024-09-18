using System;
using System.Data;
using System.Windows.Forms;
using LaundrySystem.BackEnd; // Don't forget to add this

namespace LaundrySystem.AdminPages
{
    public partial class CustomerFormAdmin : Form
    {
        private MySqlProcedure mySqlProcedure;

        public CustomerFormAdmin()
        {
            InitializeComponent();
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

        private void DisplayAllCustomers()
        {
            // Retrieve the customer data using MySqlProcedure
            DataTable customerData = mySqlProcedure.GetAllCustomers();

            // Bind the data to the DataGridView
            if (customerData != null && customerData.Rows.Count > 0)
            {
                dataGridViewDisplayCustomer.DataSource = customerData;
            }
            else
            {
                MessageBox.Show("No customer data available.");
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
    }
}
