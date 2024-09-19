using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class SearchCustomers
    {
        private MySqlProcedure mySqlProcedure;

        // Constructor to initialize MySqlProcedure
        public SearchCustomers()
        {
            mySqlProcedure = new MySqlProcedure();
        }

        public DataTable Search(string searchText)
        {
            DataTable customerTable = new DataTable();

            try
            {
      
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    string prcSearchCustomers = @"
                        SELECT * 
                        FROM customers 
                        WHERE fullname LIKE @searchText
                        OR contactno LIKE @searchText
                        OR emailadd LIKE @searchText;";

                    using (MySqlCommand cmd = new MySqlCommand(prcSearchCustomers, mySqlProcedure.conLaundry))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(customerTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for customers: " + ex.Message);
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }

            return customerTable;
        }
    }
}
