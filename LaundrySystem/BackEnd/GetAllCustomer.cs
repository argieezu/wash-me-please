using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class GetAllCustomer
    {
        private MySqlProcedure mySqlProcedure;

        // Constructor to initialize MySqlProcedure
        public GetAllCustomer()
        {
            mySqlProcedure = new MySqlProcedure();
        }

        // Method to get all customers
        public DataTable GetAllCustomers()
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand Command = new MySqlCommand("prcDisplayAllCustomer", mySqlProcedure.conLaundry))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(Command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to retrieve customer data: " + err.Message);
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }

            return dataTable;
        }
    }
}
