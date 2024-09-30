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

        public void AddTransactionsToDatabase(string cid, string stffid, string sid, decimal weight, string cgid, decimal amount, string status, DateTime dateDelivered, DateTime dateClaimed)
        {
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlTransaction transaction = sqlProcedure.conLaundry.BeginTransaction())
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcAddTransaction", sqlProcedure.conLaundry, transaction))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("p_customer_id", cid);
                        sqlCommand.Parameters.AddWithValue("p_staff_id", stffid);
                        sqlCommand.Parameters.AddWithValue("p_service_type", sid);
                        sqlCommand.Parameters.AddWithValue("p_weight", weight);
                        sqlCommand.Parameters.AddWithValue("p_garment_type", cgid);
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
