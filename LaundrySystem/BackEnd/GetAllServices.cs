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
            sqlProcedure.dataTable = new DataTable();

            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    sqlProcedure.sqlCommand = new MySqlCommand("prcDisplayServices", sqlProcedure.conLaundry);
                    sqlProcedure.adapter = new MySqlDataAdapter(sqlProcedure.sqlCommand);
                    sqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;

                        {
                            sqlProcedure.adapter.Fill(sqlProcedure.dataTable);
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
            return sqlProcedure.dataTable;
        }
    }
}
