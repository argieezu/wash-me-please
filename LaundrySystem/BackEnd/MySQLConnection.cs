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
            string DisplayAllCustomer = "prcDisplayMe";
            try
            {
                MySqlCommand cmd = new MySqlCommand(DisplayAllCustomer,conLaundry);
                cmd.CommandType = CommandType.StoredProcedure;

                servername = "localhost";
                databasename = "laundry";
                username = "root";
                password = "";
                port = "3360";


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
                MessageBox.Show("Error Message ya" + err.Message);
            } return false;
        }
    }
}
