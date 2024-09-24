using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.BackEnd
{
    internal class DeleteStaff
    {
        private MySqlProcedure mySqlProcedure;

        public DeleteStaff()
        {
            mySqlProcedure = new MySqlProcedure();
        }

        public void DeleteStaffById(int staffId)
        {
            try
            {
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcDeleteStaff", mySqlProcedure.conLaundry))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("staffId", staffId);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No staff found with the given ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff: " + ex.Message);
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
