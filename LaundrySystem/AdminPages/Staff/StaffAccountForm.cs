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

        public StaffAccountForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 3000; 
            refreshTimer.Tick += new EventHandler(OnTimerTick);
            refreshTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            DisplayAllStaff();
        }

        private void DisplayAllStaff()
        {
            try
            {
                GetAllStaff getAllStaff = new GetAllStaff();
                DataTable staffData = getAllStaff.GetAllStaffs();

                if (staffData != null && staffData.Rows.Count > 0)
                {
                    dataGridViewStaff.DataSource = staffData; 
                }
                else
                {
                    dataGridViewStaff.DataSource = null; 
                    MessageBox.Show("No staff data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve staff data: " + ex.Message);
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

        private void StaffAccountForm_Load(object sender, EventArgs e)
        {
            DisplayAllStaff();
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
