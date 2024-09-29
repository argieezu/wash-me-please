using LaundrySystem.AdminPages.Trasaction;
using LaundrySystem.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem.AdminPages
{
    public partial class TransactionFormAdmin : Form
    {
        public TransactionFormAdmin()
        {
            InitializeComponent();
        }

        private void TransactionFormAdmin_Load(object sender, EventArgs e)
        {
            PopulateComboBoxCustomer();
            PopulateComboBoxStaff();
            PopulateComboBoxGarments();
            PopulateComboBoxServices();
        }

        private void PopulateComboBoxCustomer()
        {
            GetAllCustomer getAllCustomer = new GetAllCustomer();
            DataTable customerDataTable = getAllCustomer.GetAllCustomers();

            if (customerDataTable != null && customerDataTable.Rows.Count > 0)
            {
                comboBoxCustomer.DataSource = customerDataTable;
                comboBoxCustomer.DisplayMember = "fullname";

                comboBoxCustomer.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No customer data found or table is empty.");
            }
        }

        private void PopulateComboBoxStaff()
        {
            GetAllStaff getAllStaff = new GetAllStaff();
            DataTable staffDataTable = getAllStaff.GetAllStaffs();

            if (staffDataTable != null && staffDataTable.Rows.Count > 0)
            {
                comboBoxStaff.DataSource = staffDataTable;
                comboBoxStaff.DisplayMember = "fullname";
                comboBoxStaff.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No staff data found or table is empty.");
            }

        }

        private void PopulateComboBoxGarments()
        {
            GetAllGarments getAllGarments = new GetAllGarments();
            DataTable garmentsDataTable = getAllGarments.GetAllGarment();

            if (garmentsDataTable != null && garmentsDataTable.Rows.Count > 0)
            {
                comboBoxGarmentsType.DataSource = garmentsDataTable;
                comboBoxGarmentsType.DisplayMember = "garment_type";
                comboBoxGarmentsType.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No garment data found or table is empty.");
            }
        }

        private void PopulateComboBoxServices()
        {
            GetAllServices getAllServices = new GetAllServices();
            DataTable servicesDataTable = getAllServices.GetAllService();

            if (servicesDataTable != null && servicesDataTable.Rows.Count > 0)
            {
                comboBoxServicesType.DataSource = servicesDataTable;
                comboBoxServicesType.DisplayMember = "service_type";
                comboBoxServicesType.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No services data found or table is empty.");
            }
        }

        private void buttonTrasactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionHistory = new TransactionHistory();
            this.Hide();
            transactionHistory.ShowDialog();
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxCustomer.SelectedIndex != -1)
            {
                string selectedCustomerName = comboBoxCustomer.Text;
            }
        }

        private void comboBoxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStaff.SelectedIndex != -1)
            {
                string selectedStaffName = comboBoxStaff.Text;
            }
        }
        private void comboBoxServicesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServicesType.SelectedIndex != -1)
            {
                string selectedServicesType = comboBoxServicesType.Text;
            }
        }

        private void comboBoxGarmentsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGarmentsType.SelectedIndex != -1)
            {
                string selectedGarmentsType = comboBoxGarmentsType.Text;
            }
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            // Get selected values
            string customerfullname = comboBoxCustomer.Text.Trim();
            string stafffullname = comboBoxStaff.Text.Trim();
            string serviceType = comboBoxServicesType.Text.Trim();
            string garmentType = comboBoxGarmentsType.Text.Trim();
            string status = comboBoxTransactionStatus.Text.Trim();
            decimal weight = Convert.ToDecimal(textBoxWeight.Text.Trim());
            decimal amount = Convert.ToDecimal(textBoxAmount.Text.Trim());
            DateTime dateDelivered = dateTimePickerDateDelivered.Value;
            DateTime dateClaimed = dateTimePickerDateClaimed.Value;

            if (string.IsNullOrEmpty(customerfullname) || string.IsNullOrEmpty(stafffullname) || string.IsNullOrEmpty(serviceType) || string.IsNullOrEmpty(garmentType) || string.IsNullOrEmpty(status) || weight <= 0 || amount <= 0)
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            try
            {
                AddTransaction addTransaction = new AddTransaction();
                addTransaction.AddTransactionsToDatabase(customerfullname,
                                                         stafffullname,
                                                         serviceType,
                                                         weight,
                                                         garmentType,
                                                         amount,
                                                         status,
                                                         dateDelivered,
                                                         dateClaimed);

                comboBoxCustomer.SelectedIndex = -1;
                comboBoxStaff.SelectedIndex = -1;
                comboBoxServicesType.SelectedIndex = -1;
                comboBoxGarmentsType.SelectedIndex = -1;
                textBoxWeight.Clear();
                textBoxAmount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateDelivered_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateClaimed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTransactionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
