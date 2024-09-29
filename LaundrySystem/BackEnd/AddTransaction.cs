using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class AddTransaction
    {
        private MySqlProcedure sqlProcedure;

        public AddTransaction()
        {
            sqlProcedure = new MySqlProcedure();
        }

        public void AddTransactionsToDatabase(string customerfullname, string stafffullname, string serviceType, decimal weight, string garmentType, decimal amount, string status, DateTime dateDelivered, DateTime dateClaimed)
        {
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlTransaction transaction = sqlProcedure.conLaundry.BeginTransaction())
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcAddTransaction", sqlProcedure.conLaundry, transaction))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("p_customerfullname", customerfullname);
                        sqlCommand.Parameters.AddWithValue("p_stafffullname", stafffullname);
                        sqlCommand.Parameters.AddWithValue("p_service_type", serviceType);
                        sqlCommand.Parameters.AddWithValue("p_weight", weight);
                        sqlCommand.Parameters.AddWithValue("p_garment_type", garmentType);
                        sqlCommand.Parameters.AddWithValue("p_amount", amount);
                        sqlCommand.Parameters.AddWithValue("p_status", status);
                        sqlCommand.Parameters.AddWithValue("p_date_delivered", dateDelivered);
                        sqlCommand.Parameters.AddWithValue("p_date_claimed", dateClaimed);

                        sqlCommand.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Transaction successfully added!");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to add transaction: " + e.Message);
            }
            finally
            {
                sqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
