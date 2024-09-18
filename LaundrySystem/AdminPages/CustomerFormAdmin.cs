using LaundrySystem.BackEnd;
using System;
using System.Data;
using System.Windows.Forms;

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

            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }




        private void dataGridViewDisplayCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewCustomerAdmin_Click(object sender, EventArgs e)
        {
            AddingCustomerForm addingcustomer = new AddingCustomerForm();
            addingcustomer.ShowDialog();
        }
    }
}
