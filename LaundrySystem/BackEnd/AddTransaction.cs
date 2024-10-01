using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Transactions;
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
                    sqlProcedure.transaction = sqlProcedure.conLaundry.BeginTransaction();
                    sqlProcedure.sqlCommand = new MySqlCommand("prcAddTransaction", sqlProcedure.conLaundry, sqlProcedure.transaction);
             
                    
                        sqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_customer_id", cid);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_staff_id", stffid);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_service_type", sid);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_weight", weight);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_garment_type", cgid);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_amount", amount);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_status", status);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_date_delivered", dateDelivered);
                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_date_claimed", dateClaimed);

                        sqlProcedure.sqlCommand.ExecuteNonQuery();
                        sqlProcedure.transaction.Commit();
                        MessageBox.Show("Transaction successfully added!");
                    
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
