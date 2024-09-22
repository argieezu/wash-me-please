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
            InitializeTimer();

        }
        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 3000;
            refreshTimer.Tick += new EventHandler(onTimer_Tick);
            refreshTimer.Start();
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
            try
            {
                if (dataGridViewStaff.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewStaff.SelectedRows[0];

                    if (selectedRow.Cells.Count > 0)
                    {
                        int staffId;

                        if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out staffId))
                        {
                            DialogResult dialogResult = MessageBox.Show(
                                "Are you sure you want to delete this staff?",
                                "Confirm Deletion",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (dialogResult == DialogResult.Yes)
                            {
                                DeleteStaff deleteStaff = new DeleteStaff();
                                deleteStaff.DeleteStaffById(staffId);

                                DisplayAllStaff();
                            }
                            else
                            {
                                MessageBox.Show("Staff deletion cancelled.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid staff ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain any data.");
                    }
                }
                else
                {
                    MessageBox.Show("Select a staff to delete.");
                }
            }
            catch (Exception ex) { 
            }

        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEditStaffAdmin_Click(object sender, EventArgs e)
        {
        }

        private void onTimer_Tick(object sender, EventArgs e)
        {
            DisplayAllStaff();
        }
    }
}
