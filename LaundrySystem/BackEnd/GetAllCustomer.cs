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
            mySqlProcedure.dataTable = new DataTable();     

            try
            {
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    mySqlProcedure.sqlCommand = new MySqlCommand("prcDisplayAllCustomer", mySqlProcedure.conLaundry);
                    mySqlProcedure.adapter = new MySqlDataAdapter(mySqlProcedure.sqlCommand);
                    mySqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;                

                        {
                            mySqlProcedure.adapter.Fill(mySqlProcedure.dataTable);
                        }
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to retrieve customer data: " + e.Message);  
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }

            return mySqlProcedure.dataTable;
        }
    }
}
