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
                    using (MySqlCommand cmd = new MySqlCommand("prcDeleteStaff", mySqlProcedure.conLaundry))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("staffId", staffId);

                        int rowsAffected = cmd.ExecuteNonQuery();

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
