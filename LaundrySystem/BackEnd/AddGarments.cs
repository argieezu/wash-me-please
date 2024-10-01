using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LaundrySystem.BackEnd
{
    internal class AddGarments
    {
        private MySqlProcedure sqlProcedure;

        public AddGarments()
        {
            sqlProcedure = new MySqlProcedure();
        }

        public void AddGarmentsToDatabase(string garment_type)
        {
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    sqlProcedure.transaction = sqlProcedure.conLaundry.BeginTransaction();
                    sqlProcedure.sqlCommand = new MySqlCommand("procAddGarmentsType", sqlProcedure.conLaundry, sqlProcedure.transaction);
                    
                        sqlProcedure.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlProcedure.sqlCommand.Parameters.Clear();

                        sqlProcedure.sqlCommand.Parameters.AddWithValue("p_garmenttype", garment_type);

                        sqlProcedure.sqlCommand.ExecuteNonQuery();
                        sqlProcedure.transaction.Commit();
                        MessageBox.Show("New garment successfully added! ");
                    
                }
            } catch (Exception e)
            {
                MessageBox.Show("Failed to add garment: " + e.Message);
            }
            finally
            {
                sqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
