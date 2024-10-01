using MySql.Data.MySqlClient;
using System;
using System.Transactions;
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
                    mySqlProcedure.transaction = mySqlProcedure.conLaundry.BeginTransaction();
                    mySqlProcedure.sqlCommand = new MySqlCommand("procAddStaff", mySqlProcedure.conLaundry, mySqlProcedure.transaction);
                    
                        mySqlProcedure.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_fullname", fullname);
                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_birthdate", birthdate);
                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_gender", gender);
                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_address", address);
                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_contactno", contactNo);
                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_emailadd", emailadd);
                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_username", username);
                        mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_password", PASSWORD);

                        mySqlProcedure.sqlCommand.ExecuteNonQuery();
                        mySqlProcedure.transaction.Commit();
                        MessageBox.Show("Staff added successfully!");
                    
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
