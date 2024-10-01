using LaundrySystem.BackEnd;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem
{
    internal class SearchCustomer
    {
        MySqlProcedure sqlProcedure = new MySqlProcedure();

        public DataTable getCustomerList(string fullname)
        {
            sqlProcedure.dataTable = new DataTable();
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    sqlProcedure.sqlCommand = new MySqlCommand("prcSearchCustomers", sqlProcedure.conLaundry);
                    sqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlProcedure.sqlCommand.Parameters.Clear();
                    sqlProcedure.sqlCommand.Parameters.AddWithValue("p_fullname", fullname); 

                    sqlProcedure.adapter = new MySqlDataAdapter(sqlProcedure.sqlCommand);
                    sqlProcedure.adapter.Fill(sqlProcedure.dataTable);
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

            return sqlProcedure.dataTable;
        }

    }
}
