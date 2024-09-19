using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class AddCustomer
    {
        private MySqlProcedure _mySqlProcedure;

        // Constructor to initialize MySqlProcedure
        public AddCustomer()
        {
            _mySqlProcedure = new MySqlProcedure();
        }

        // Method to add a new customer
        public void AddCustomerToDatabase(string fullname, DateTime birthdate, string gender, string address, string contactNo, string email, string photo)
        {
            try
            {
                if (_mySqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlTransaction transaction = _mySqlProcedure.conLaundry.BeginTransaction())
                    using (MySqlCommand cmd = new MySqlCommand("procAddCustomer", _mySqlProcedure.conLaundry, transaction))
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
                _mySqlProcedure.checkDatabaseConnection();
            }
        }
    }
}
