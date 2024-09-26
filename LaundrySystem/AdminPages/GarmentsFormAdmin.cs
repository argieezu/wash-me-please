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
    public partial class GarmentsFormAdmin : Form
    {
        public GarmentsFormAdmin()
        {
            InitializeComponent();
        }

        private void LoadGarments()
        {
            try
            {
                GetAllGarments getAllGarments = new GetAllGarments();
                DataTable dataTable = getAllGarments.GetAllGarment();

                if (dataTable.Rows.Count > 0)
                {
                    dataGridViewDisplayGarmentsType.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No garments available to display.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading garments: " + e.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddGarmentType_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddGarmentsType_Click(object sender, EventArgs e)
        {
            try
            {
                string garment_type = textBoxAddGarmentType.Text;

                if (string.IsNullOrEmpty(garment_type))
                {
                    MessageBox.Show("Please enter a garment type.");
                    return;
                }

                AddGarments addGarments = new AddGarments();
                addGarments.AddGarmentsToDatabase(garment_type);

                MessageBox.Show("Garment added successfully!");

                textBoxAddGarmentType.Clear();
                LoadGarments();
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to add garment: " + err.Message);
            }
        }

        private void dataGridViewDisplayGarmentsType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GarmentsFormAdmin_Load(object sender, EventArgs e)
        {
            LoadGarments();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
