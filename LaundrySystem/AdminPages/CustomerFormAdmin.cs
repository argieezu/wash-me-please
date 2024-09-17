using LaundrySystem.BackEnd;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LaundrySystem.AdminPages
{
    public partial class CustomerFormAdmin : Form
    {
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;

        public MySqlConnection conLaundry;
        public MySqlCommand slqCommand;
        public string strConnection;

        public CustomerFormAdmin()
        {


            InitializeComponent();
        }

        private void dataGridViewDisplayCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerFormAdmin_Load(object sender, EventArgs e)
        {
           
            MySqlProcedure mySqlProcedure = new fncConnectToDatabase();
            
       
        }
      
        

    }
}
