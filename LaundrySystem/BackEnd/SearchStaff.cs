using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.BackEnd
{
    internal class SearchStaff
    {
        MySqlProcedure sqlProcedure = new MySqlProcedure();

        public DataTable getStaffList(string fullname)
        {
            sqlProcedure.dataTable = new DataTable();

            try
            {
                if (sqlProcedure.fncConnectToDatabase())
                {
                    sqlProcedure.sqlCommand = new MySqlCommand("prcSearchStaff", sqlProcedure.conLaundry);
                    sqlProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlProcedure.sqlCommand.Parameters.Clear();
                    sqlProcedure.sqlCommand.Parameters.AddWithValue("p_fullname", fullname);

                    sqlProcedure.adapter = new MySqlDataAdapter(sqlProcedure.sqlCommand);
                    sqlProcedure.adapter.Fill(sqlProcedure.dataTable);
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (sqlProcedure.conLaundry != null && sqlProcedure.conLaundry.State == ConnectionState.Open)
                {
                    sqlProcedure.conLaundry.Close();
                }
            }

            return sqlProcedure.dataTable;
        }
    }
}
