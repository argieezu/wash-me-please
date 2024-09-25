using MySql.Data.MySqlClient;
using System;
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
                    using (MySqlTransaction transaction = sqlProcedure.conLaundry.BeginTransaction())
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcAddServices", sqlProcedure.conLaundry, transaction))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure; 
                        sqlCommand.Parameters.Clear();

                        sqlCommand.Parameters.AddWithValue("p_servicetype", service_type);
                        sqlCommand.Parameters.AddWithValue("p_description", description);
                        sqlCommand.Parameters.AddWithValue("p_price", price);

                        sqlCommand.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("New service successfully added!");
                    }
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
