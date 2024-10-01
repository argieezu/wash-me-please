using MySql.Data.MySqlClient;
using System;
using System.Transactions;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class AddServices
    {
        private MySqlProcedure sqlProcedure;

        public AddServices()
        {
            sqlProcedure = new MySqlProcedure();
        }

        public void AddServicesToDatabase(string service_type, string description, string price)
        {
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    sqlProcedure.transaction = sqlProcedure.conLaundry.BeginTransaction();
                    sqlProcedure.sqlCommand = new MySqlCommand("prcAddServices", sqlProcedure.conLaundry, sqlProcedure.transaction);

                    
                        sqlProcedure.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure; 
                        sqlProcedure.sqlCommand.Parameters.Clear();

                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_servicetype", service_type);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_description", description);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_price", price);

                        sqlProcedure.sqlCommand.ExecuteNonQuery();
                        sqlProcedure.transaction.Commit();
                        MessageBox.Show("New service successfully added!");
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to add service: " + e.Message);
            }
            finally
            {
                sqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
