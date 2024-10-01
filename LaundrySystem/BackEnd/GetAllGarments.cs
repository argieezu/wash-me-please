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
            sqlProcedure.dataTable = new DataTable(); 

            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    sqlProcedure.sqlCommand = new MySqlCommand("prcDisplayAllGarment", sqlProcedure.conLaundry);
                    sqlProcedure.adapter = new MySqlDataAdapter(sqlProcedure.sqlCommand);
                    sqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;

                        {
                            sqlProcedure.adapter.Fill(sqlProcedure.dataTable);
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
            return sqlProcedure.dataTable;
        }
    }
}
