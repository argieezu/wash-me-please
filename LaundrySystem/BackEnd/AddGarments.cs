using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    using (MySqlTransaction transaction = sqlProcedure.conLaundry.BeginTransaction()) 
                    using (MySqlCommand sqlCommand = new MySqlCommand("procAddGarmentsType", sqlProcedure.conLaundry, transaction))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.Clear();

                        sqlCommand.Parameters.AddWithValue("p_garmenttype", garment_type);

                        sqlCommand.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("New garment successfully added! ");
                    }
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
