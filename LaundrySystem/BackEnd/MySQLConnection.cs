using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace LaundrySystem.BackEnd
{
    internal class MySqlProcedure
    {
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;
        public MySqlConnection conLaundry;
        public MySqlCommand slqCommand;
        public string strConnection;
        


        public bool fncConnectToDatabase()
        {
            try
            {
                servername = "localhost";
                databasename = "laundry";
                username = "root";
                password = "";
                port = "3306";


                //implement connection
                strConnection = "Server=" + servername + "; " +
                    "Database =" + databasename + "; " +
                    "User=" + username + "; " +
                    "Password=" + password + "; " +
                    "Port =" + port + "; " +
                    "Convert Zero Datetime =true";

                conLaundry = new MySqlConnection(strConnection);
                slqCommand = new MySqlCommand(strConnection, conLaundry);
                if (conLaundry.State == ConnectionState.Closed)
                {
                    slqCommand.Connection = conLaundry;
                    conLaundry.Open();
                    return true;
                }
                else
                {
                    conLaundry.Close();
                    return false;
                }
            } catch (Exception err)
            {
                MessageBox.Show("Error Message RATATOWE " + err.Message);
            } return false;
        }

        public void checkDatabaseConnection()
        {
            if (fncConnectToDatabase().Equals("False"))
            {
                conLaundry.Open();
            }
            else
            {
                //ratatowe
            }
        }
        public void AddCustomer(string fullname, DateTime birthdate, string gender, string address, string contactNo, string email, string photo)
        {
            try
            {
                if (fncConnectToDatabase())
                {
                    using (MySqlTransaction transaction = conLaundry.BeginTransaction())
                    using (MySqlCommand cmd = new MySqlCommand("procAddCustomer", conLaundry, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // add parameters
                        cmd.Parameters.AddWithValue("p_fullname", fullname);
                        cmd.Parameters.AddWithValue("p_birthdate", birthdate);
                        cmd.Parameters.AddWithValue("p_gender", gender);
                        cmd.Parameters.AddWithValue("p_address", address);
                        cmd.Parameters.AddWithValue("p_contactno", contactNo);
                        cmd.Parameters.AddWithValue("p_emailadd", email);
                        cmd.Parameters.AddWithValue("p_cust_photo", photo);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        // Commit the transaction
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
                if (conLaundry.State == ConnectionState.Open)
                {
                    conLaundry.Close();
                }
            }
        }
        public DataTable GetAllCustomers()
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (fncConnectToDatabase())
                {
                    using (MySqlCommand cmd = new MySqlCommand("prcDisplayAllCustomer", conLaundry))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to retrieve customer data: " + err.Message);
            }
            finally
            {
                if (conLaundry.State == ConnectionState.Open)
                {
                    conLaundry.Close();
                }
            }

            return dataTable;
        }



    }
}
