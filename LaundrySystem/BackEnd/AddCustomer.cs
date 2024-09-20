using MySql.Data.MySqlClient;
using System;
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
                    using (MySqlCommand cmd = new MySqlCommand("procAddCustomer", mySqlProcedure.conLaundry, transaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_fullname", fullname);
                        cmd.Parameters.AddWithValue("p_birthdate", birthdate);
                        cmd.Parameters.AddWithValue("p_gender", gender);
                        cmd.Parameters.AddWithValue("p_address", address);
                        cmd.Parameters.AddWithValue("p_contactno", contactNo);
                        cmd.Parameters.AddWithValue("p_emailadd", email);
                        cmd.Parameters.AddWithValue("p_cust_photo", photo);

                        cmd.ExecuteNonQuery();
                        transaction.Commit();
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
