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
            DataTable dataTable = new DataTable();

            try
            {
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand Command = new MySqlCommand("prcDisplayAllStaff", mySqlProcedure.conLaundry))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(Command))
                        {
                            adapter.Fill(dataTable);
                        }
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

            return dataTable;
        }
    }

}
