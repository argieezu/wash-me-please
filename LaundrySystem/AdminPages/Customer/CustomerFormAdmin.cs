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

        // Refresh timer
        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 3000;
            refreshTimer.Tick += new EventHandler(OnTimerTick);
            refreshTimer.Start();
        }

        private void CustomerFormAdmin_Load(object sender, EventArgs e)
        {
            mySqlProcedure = new MySqlProcedure();

            if (mySqlProcedure.fncConnectToDatabase())
            {
                DisplayAllCustomers();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            DisplayAllCustomers();
        }

        private void DisplayAllCustomers()
        {
            try
            {
                GetAllCustomer getAllCustomer = new GetAllCustomer();
                DataTable customerData = getAllCustomer.GetAllCustomers();

                if (customerData != null && customerData.Rows.Count > 0)
                {
                    dataGridViewDisplayCustomer.DataSource = customerData;
                }
                else
                {
                    dataGridViewDisplayCustomer.DataSource = null;
                    MessageBox.Show("No customer data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // New customer button 
        private void btnNewCustomerAdmin_Click(object sender, EventArgs e)
        {
            AddingCustomerForm addingcustomer = new AddingCustomerForm();
            if (addingcustomer.ShowDialog() == DialogResult.OK)
            {
                DisplayAllCustomers();
            }
        }

        // Search customer by name
        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchCustomer customerProcedure = new SearchCustomer();
                DataTable customerData = customerProcedure.getCustomerList(textBoxSearchCustomer.Text.Trim());

                if (customerData != null && customerData.Rows.Count > 0)
                {
                    dataGridViewDisplayCustomer.DataSource = customerData;
                }
                else
                {
                    dataGridViewDisplayCustomer.DataSource = null; 
                    MessageBox.Show("No matching customer found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }


        // Deleting selected customer
        private void btnDeleteCustomerAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDisplayCustomer.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewDisplayCustomer.SelectedRows[0];

                    if (selectedRow.Cells.Count > 0)
                    {
                        int customerId;

                        if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out customerId))
                        {
                            DialogResult dialogResult = MessageBox.Show(
                                "Are you sure you want to delete this customer?",
                                "Confirm Deletion",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (dialogResult == DialogResult.Yes)
                            {
                                DeleteCustomer deleteCustomer = new DeleteCustomer();
                                deleteCustomer.DeleteCustomerById(customerId);

                                DisplayAllCustomers();
                            }
                            
                        }
                        
                    }
                   
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
