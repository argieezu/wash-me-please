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

namespace LaundrySystem.AdminPages.Staff
{
    public partial class AddingStaffForm : Form
    {
        public AddingStaffForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddingStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fullname = txtbxFullNameStaff.Text;
                DateTime birthdate = dateTimePickerBirthdateStaff.Value;
                string gender = comboBoxGenderStaff.SelectedItem.ToString();
                string address = txtbxAddressStaff.Text;
                string contactNo = txtbxContactNoStaff.Text;
                string email = txtbxEmailSTAFF.Text;
                string username = textBoxUsernameStaff.Text;
                string password = textBoxPasswordStaff.Text;


                AddStaff addStaff = new AddStaff();
                addStaff.AddStaffToDatabase(fullname, birthdate, gender, address, contactNo, email, username, password);

                MessageBox.Show("Staff added successfully!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to add staff: " + err.Message);
            }
            this.Close();
        }

    }
}
