using LaundrySystem.BackEnd;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem
{
    internal class CustomerProcedure
    {
        MySqlProcedure sqlProcedure = new MySqlProcedure();

        // Method to search and return customers based on fullname
        public DataTable getCustomerList(string fullname)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    // Initialize the command
                    sqlProcedure.sqlCommand = new MySqlCommand("prcSearchCustomers", sqlProcedure.conLaundry);
                    sqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Clear previous parameters and add new ones
                    sqlProcedure.sqlCommand.Parameters.Clear();
                    sqlProcedure.sqlCommand.Parameters.AddWithValue("p_fullname", fullname);

                    // Execute and fill the DataTable
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlProcedure.sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlProcedure.conLaundry.Close();
            }

            return dataTable;
        }
    }
}
