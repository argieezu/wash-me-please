using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class AddCustomer
    {
        private MySqlProcedure mySqlProcedure;

        public AddCustomer()
        {
            mySqlProcedure = new MySqlProcedure();
        }

        public void AddCustomerToDatabase(string fullname, DateTime birthdate, string gender, string address, string contactNo, string email, string photo)
        {
            try
            {
                if (mySqlProcedure.fncConnectToDatabase())
                {
                    mySqlProcedure.transaction = mySqlProcedure.conLaundry.BeginTransaction();
                    mySqlProcedure.sqlCommand = new MySql.Data.MySqlClient.MySqlCommand("procAddCustomer", mySqlProcedure.conLaundry, mySqlProcedure.transaction);

                    mySqlProcedure.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_fullname", fullname);
                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_birthdate", birthdate);
                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_gender", gender);
                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_address", address);
                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_contactno", contactNo);
                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_emailadd", email);
                    mySqlProcedure.sqlCommand.Parameters.AddWithValue("p_cust_photo", photo);

                            mySqlProcedure.sqlCommand.ExecuteNonQuery();
                        mySqlProcedure.transaction.Commit();
                        MessageBox.Show("Customer Successfully Added!");
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to add customer: " + err.Message);
            }
            finally
            {
                mySqlProcedure.checkDatabaseConnection();
            }
        }
    }
}