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
                    using (MySqlCommand cmd = new MySqlCommand("procAddStaff", mySqlProcedure.conLaundry, transaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_fullname", fullname);
                        cmd.Parameters.AddWithValue("p_birthdate", birthdate);
                        cmd.Parameters.AddWithValue("p_gender", gender);
                        cmd.Parameters.AddWithValue("p_address", address);
                        cmd.Parameters.AddWithValue("p_contactno", contactNo);
                        cmd.Parameters.AddWithValue("p_emailadd", emailadd);
                        cmd.Parameters.AddWithValue("p_username", username);
                        cmd.Parameters.AddWithValue("p_password", PASSWORD);

                        cmd.ExecuteNonQuery();

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
