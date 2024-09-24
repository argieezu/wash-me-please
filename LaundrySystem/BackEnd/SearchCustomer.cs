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

        public DataTable getCustomerList(string fullname)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    sqlProcedure.sqlCommand = new MySqlCommand("prcSearchCustomers", sqlProcedure.conLaundry);
                    sqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlProcedure.sqlCommand.Parameters.Clear();
                    sqlProcedure.sqlCommand.Parameters.AddWithValue("p_fullname", fullname); 

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
                if (sqlProcedure.conLaundry != null && sqlProcedure.conLaundry.State == ConnectionState.Open)
                {
                    sqlProcedure.conLaundry.Close();
                }
            }

            return dataTable;
        }

    }
}
