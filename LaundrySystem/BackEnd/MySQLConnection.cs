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
        public MySqlCommand sqlCommand;
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
                sqlCommand = new MySqlCommand(strConnection, conLaundry);
                if (conLaundry.State == ConnectionState.Closed)
                {
                    sqlCommand.Connection = conLaundry;
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

    }
}
