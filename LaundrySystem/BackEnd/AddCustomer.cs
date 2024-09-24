using MySql.Data.MySqlClient;
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
                    using (MySqlTransaction transaction = mySqlProcedure.conLaundry.BeginTransaction())
                    using (MySqlCommand sqlCommand = new MySqlCommand("procAddCustomer", mySqlProcedure.conLaundry, transaction))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        sqlCommand.Parameters.AddWithValue("p_fullname", fullname);
                        sqlCommand.Parameters.AddWithValue("p_birthdate", birthdate);
                        sqlCommand.Parameters.AddWithValue("p_gender", gender);
                        sqlCommand.Parameters.AddWithValue("p_address", address);
                        sqlCommand.Parameters.AddWithValue("p_contactno", contactNo);
                        sqlCommand.Parameters.AddWithValue("p_emailadd", email);
                        sqlCommand.Parameters.AddWithValue("p_cust_photo", photo);

                        sqlCommand.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Customer Successfully Added!");
                    }
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