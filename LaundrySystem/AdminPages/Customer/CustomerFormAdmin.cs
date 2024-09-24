using System;
using System.Data;
using System.Windows.Forms;
using LaundrySystem.BackEnd;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        //  refresh timer for customer data so that it will auto display the new customer in datagrid
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


        private void btnNewCustomerAdmin_Click(object sender, EventArgs e)
        {
            AddingCustomerForm addingcustomer = new AddingCustomerForm();
            if (addingcustomer.ShowDialog() == DialogResult.OK)
            {

                DisplayAllCustomers();
            }
        }


        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
               
                CustomerProcedure customerProcedure = new CustomerProcedure();

                // Get the filtered customer data and bind it to the DataGridView
                dataGridViewDisplayCustomer.DataSource = customerProcedure.getCustomerList(textBoxSearchCustomer.Text.Trim());
            
        }




        private void dataGridViewDisplayCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            
        }

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
                            else
                            {
                                MessageBox.Show("Customer deletion cancelled.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid customer ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain any data.");
                    }
                }
                else
                {
                    MessageBox.Show("Select a customer to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
