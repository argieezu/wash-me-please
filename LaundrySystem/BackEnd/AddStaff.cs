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

        public void AddStaffToDatabase(string fullname, DateTime birthdate, string gender, string address, string contactNo, string email, string photo, string username, string password)
        {
            try
            {
                // Check and connect to the database
                mySqlProcedure.checkDatabaseConnection();

                if (mySqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlTransaction transaction = mySqlProcedure.conLaundry.BeginTransaction())
                    using (MySqlCommand Command = new MySqlCommand("procAddStaff", mySqlProcedure.conLaundry, transaction))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        Command.Parameters.AddWithValue("p_fullname", fullname);
                        Command.Parameters.AddWithValue("p_birthdate", birthdate);
                        Command.Parameters.AddWithValue("p_gender", gender);
                        Command.Parameters.AddWithValue("p_address", address);
                        Command.Parameters.AddWithValue("p_contactno", contactNo);
                        Command.Parameters.AddWithValue("p_emailadd", email);
                        Command.Parameters.AddWithValue("p_photo", photo);
                        Command.Parameters.AddWithValue("p_username", username);
                        Command.Parameters.AddWithValue("p_password", password);

                        // Execute the query
                        Command.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();

                        MessageBox.Show("Staff added successfully!");
                    }
                }
            }
            catch (Exception err)
            {
                // Rollback transaction if error occurs
                MessageBox.Show("Failed to add staff: " + err.Message);
            }
            finally
            {
                // Ensure the database connection is properly closed
                if (mySqlProcedure.conLaundry.State == System.Data.ConnectionState.Open)
                {
                    mySqlProcedure.conLaundry.Close();
                }
            }
        }
    }
}
