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
    public partial class AddingCustomerForm : Form
    {
        public AddingCustomerForm()
        {
            InitializeComponent();

        }

        private void AddingCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageProfile.Image = new Bitmap(openFileDialog.FileName);
            }
        }



        private void dateTimePickerBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect values from the form
                string fullname = txtbxFullName.Text;
                DateTime birthdate = dateTimePickerBirthdate.Value;
                string gender = comboBoxGender.SelectedItem.ToString();
                string address = txtbxAddress.Text;
                string contactNo = txtbxContactNo.Text;
                string email = txtbxEmail.Text;
                string photo = pictureBoxImageProfile.Image != null ? ConvertImageToBase64(pictureBoxImageProfile.Image) : null;

                // Use the AddCustomer class
                AddCustomer addCustomer = new AddCustomer();
                addCustomer.AddCustomerToDatabase(fullname, birthdate, gender, address, contactNo, email, photo);

                MessageBox.Show("Customer added successfully!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to add customer: " + err.Message);
            }
            this.Close();
        }


        private string ConvertImageToBase64(Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void txtbxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
