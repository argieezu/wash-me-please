using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class GetAllServices
    {
        private MySqlProcedure sqlProcedure;

        public GetAllServices()
        {
            sqlProcedure = new MySqlProcedure();
        }

        public DataTable GetAllService()
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcDisplayServices", sqlProcedure.conLaundry))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Use MySqlDataAdapter to fill the DataTable with the result set
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to retrieve services data: " + e.Message);
            }
            finally
            {
                sqlProcedure.checkDatabaseConnection();
            }
            return dataTable;
        }
    }
}
