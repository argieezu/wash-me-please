using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class GetAllStaff
    {
        private MySqlProcedure mySqlProcedure;

        public GetAllStaff()
        {
            mySqlProcedure = new MySqlProcedure();
        }

        public DataTable GetAllStaffs()
        {
            mySqlProcedure.dataTable = new DataTable();

            try
            {
                if (mySqlProcedure.fncConnectToDatabase())
                {

                    mySqlProcedure.sqlCommand = new MySqlCommand("prcDisplayAllStaff", mySqlProcedure.conLaundry);
                    mySqlProcedure.adapter = new MySqlDataAdapter(mySqlProcedure.sqlCommand);
                    mySqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;

                        {
                            mySqlProcedure.adapter.Fill(mySqlProcedure.dataTable);
                        }
                    
                }
                else
                {
                    MessageBox.Show("Failed to connect to database.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to retrieve staff data: " + err.Message);
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }

            return mySqlProcedure.dataTable;
        }
    }

}
