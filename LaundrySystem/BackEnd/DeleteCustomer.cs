using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class DeleteCustomer
    {
        private MySqlProcedure _mySqlProcedure;

        // Constructor to initialize MySqlProcedure
        public DeleteCustomer()
        {
            _mySqlProcedure = new MySqlProcedure();
        }

        // Method to delete a customer from the database
        public void DeleteCustomerById(int customerId)
        {
            try
            {
                if (_mySqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand cmd = new MySqlCommand("prcDeleteCustomer", _mySqlProcedure.conLaundry))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("customerId", customerId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
            finally
            {
                _mySqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
