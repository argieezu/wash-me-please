using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.BackEnd
{
    internal class FetchData
    {
        private MySqlProcedure sqlProcedure;

        public FetchData()
        {
            sqlProcedure = new MySqlProcedure();
        }

        public DataTable GetAllCustomers()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcDisplayAllCustomer", sqlProcedure.conLaundry))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching customers: " + ex.Message);
            }
            return dataTable;
        }

        public DataTable GetAllGarments()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcDisplayAllGarment", sqlProcedure.conLaundry))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching garments: " + ex.Message);
            }
            return dataTable;
        }

        public DataTable GetAllStaff()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcDisplayAllStaff", sqlProcedure.conLaundry))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching staff: " + ex.Message);
            }
            return dataTable;
        }

        public DataTable GetAllServices()
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand("prcDisplayServices", sqlProcedure.conLaundry))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching services: " + ex.Message);
            }
            return dataTable;
        }
    }
}
