using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class DeleteCustomer
    {
        private MySqlProcedure mySqlProcedure;

        // Constructor to initialize MySqlProcedure
        public DeleteCustomer()
        {
            mySqlProcedure = new MySqlProcedure();
        }

        //  delete a customer from the database
        public void DeleteCustomerById(int customerId)
        {
            try
            {
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    mySqlProcedure.sqlCommand = new MySqlCommand("prcDeleteCustomer", mySqlProcedure.conLaundry);
                    mySqlProcedure.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("customerId", customerId);

                        int rowsAffected = mySqlProcedure.sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the given ID.");
                        }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
