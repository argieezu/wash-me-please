using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.BackEnd
{
    internal class GetAllGarments
    {
        private MySqlProcedure sqlProcedure;

        public GetAllGarments()
        {
            sqlProcedure = new MySqlProcedure();
        }

        public DataTable GetAllGarment()
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcDisplayAllGarment", sqlProcedure.conLaundry))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }catch (Exception e)
            {
                MessageBox.Show("Failed to retrieve garments data: " + e.Message);
            }
            finally
            {
                sqlProcedure.checkDatabaseConnection();
            }
            return dataTable;
        }
    }
}
