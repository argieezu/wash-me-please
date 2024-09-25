using LaundrySystem.BackEnd;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaundrySystem.AdminPages
{
    public partial class ServicesFormAdmin : Form
    {
        public ServicesFormAdmin()
        {
            InitializeComponent();
        }

        // Method to load services when the form loads
        private void ServicesFormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                GetAllServices getAllServices = new GetAllServices();
                DataTable servicesTable = getAllServices.GetAllService();

                if (servicesTable.Rows.Count > 0)
                {
                    dataGridViewServiceManagement.DataSource = servicesTable;
                }
                else
                {
                    MessageBox.Show("No services available to display.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
        }

        private void buttonAddServices_Click(object sender, EventArgs e)
        {
            string serviceType = textBoxServiceType.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            string price = textBoxPrice.Text.Trim();

            if (string.IsNullOrEmpty(serviceType) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            try
            {
                AddServices addServices = new AddServices();
                addServices.AddServicesToDatabase(serviceType, description, price);

                textBoxServiceType.Clear();
                textBoxDescription.Clear();
                textBoxPrice.Clear();

                ServicesFormAdmin_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewServiceManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void textBoxServiceType_TextChanged(object sender, EventArgs e) { }

        private void textBoxPrice_TextChanged(object sender, EventArgs e) { }

        private void textBoxDescription_TextChanged(object sender, EventArgs e) { }
    }
}
