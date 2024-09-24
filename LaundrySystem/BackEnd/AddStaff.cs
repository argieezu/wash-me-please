using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class AddStaff
    {
        private MySqlProcedure mySqlProcedure;

        public AddStaff()
        {
            mySqlProcedure = new MySqlProcedure();
        }

        public void AddStaffToDatabase(string fullname, DateTime birthdate, string gender, string address, string contactNo, string emailadd,  string username, string PASSWORD)
        {
            try
            {
                // Ensure a database connection
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    // Use a transaction to ensure atomicity
                    using (MySqlTransaction transaction = mySqlProcedure.conLaundry.BeginTransaction())
                    using (MySqlCommand sqlCommand = new MySqlCommand("procAddStaff", mySqlProcedure.conLaundry, transaction))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        sqlCommand.Parameters.AddWithValue("p_fullname", fullname);
                        sqlCommand.Parameters.AddWithValue("p_birthdate", birthdate);
                        sqlCommand.Parameters.AddWithValue("p_gender", gender);
                        sqlCommand.Parameters.AddWithValue("p_address", address);
                        sqlCommand.Parameters.AddWithValue("p_contactno", contactNo);
                        sqlCommand.Parameters.AddWithValue("p_emailadd", emailadd);
                        sqlCommand.Parameters.AddWithValue("p_username", username);
                        sqlCommand.Parameters.AddWithValue("p_password", PASSWORD);

                        sqlCommand.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Staff added successfully!");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to add staff: " + err.Message);
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
