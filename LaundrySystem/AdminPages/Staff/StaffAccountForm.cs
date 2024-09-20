using LaundrySystem.AdminPages.Staff;
using LaundrySystem.BackEnd;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.AdminPages
{
    public partial class StaffAccountForm : Form
    {
        private System.Windows.Forms.Timer refreshTimer;
        private MySqlProcedure mySqlProcedure;

        public StaffAccountForm()
        {
            InitializeComponent();
      
        }

        private void StaffAccountForm_Load(object sender, EventArgs e)
        {
            mySqlProcedure = new MySqlProcedure();

            if (mySqlProcedure.fncConnectToDatabase())
            {
                DisplayAllStaff();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        private void DisplayAllStaff()
        {
            try
            {
                GetAllStaff getAllCustomer = new GetAllStaff();
                DataTable customerData = getAllCustomer.GetAllStaffs();

                if (customerData != null && customerData.Rows.Count > 0)
                {
                    dataGridViewStaff.DataSource = customerData;
                }
                else
                {
                    dataGridViewStaff.DataSource = null;
                    MessageBox.Show("No customer data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnNewStaffAdmin_Click(object sender, EventArgs e)
        {
            AddingStaffForm addingStaff = new AddingStaffForm();
            if (addingStaff.ShowDialog() == DialogResult.OK)
            {
                DisplayAllStaff(); 
            }
        }

        private void btnDeletStaffAdmin_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEditStaffAdmin_Click(object sender, EventArgs e)
        {
        }
    }
}
