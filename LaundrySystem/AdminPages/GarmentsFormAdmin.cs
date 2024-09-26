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

                AddGarments addGarments = new AddGarments();
                addGarments.AddGarmentsToDatabase(garment_type);
                MessageBox.Show("Garment added successfully! ");
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to add garment: " + err.Message);
            }
        }

        private void dataGridViewDisplayGarmentsType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
