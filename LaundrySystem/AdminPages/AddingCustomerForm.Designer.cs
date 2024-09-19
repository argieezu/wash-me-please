namespace LaundrySystem.AdminPages
{
    partial class AddingCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingCustomerForm));
            btnAddNewCustomer = new Button();
            label1 = new Label();
            pictureBoxImageProfile = new PictureBox();
            txtbxFullName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxGender = new ComboBox();
            label5 = new Label();
            txtbxAddress = new TextBox();
            label6 = new Label();
            txtbxContactNo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtbxEmail = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            dateTimePickerBirthdate = new DateTimePicker();
            buttonUploadImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageProfile).BeginInit();
            SuspendLayout();
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.BackColor = Color.FromArgb(192, 255, 192);
            btnAddNewCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewCustomer.Image = Properties.Resources.add_user;
            btnAddNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewCustomer.Location = new Point(441, 279);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(119, 33);
            btnAddNewCustomer.TabIndex = 0;
            btnAddNewCustomer.Text = "Add";
            btnAddNewCustomer.UseVisualStyleBackColor = false;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 120);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Username :";
            // 
            // pictureBoxImageProfile
            // 
            pictureBoxImageProfile.Image = (Image)resources.GetObject("pictureBoxImageProfile.Image");
            pictureBoxImageProfile.Location = new Point(427, 12);
            pictureBoxImageProfile.Name = "pictureBoxImageProfile";
            pictureBoxImageProfile.Size = new Size(147, 140);
            pictureBoxImageProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImageProfile.TabIndex = 6;
            pictureBoxImageProfile.TabStop = false;
            // 
            // txtbxFullName
            // 
            txtbxFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxFullName.Location = new Point(119, 113);
            txtbxFullName.Name = "txtbxFullName";
            txtbxFullName.Size = new Size(233, 27);
            txtbxFullName.TabIndex = 7;
            txtbxFullName.TextChanged += txtbxFullName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 149);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 8;
            label2.Text = "Birthdate :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 181);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 10;
            label3.Text = "Gender :";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Email", "Transgender" });
            comboBoxGender.Location = new Point(119, 178);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(233, 28);
            comboBoxGender.TabIndex = 12;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(119, 9);
            label5.Name = "label5";
            label5.Size = new Size(187, 37);
            label5.TabIndex = 14;
            label5.Text = "Add Customer";
            // 
            // txtbxAddress
            // 
            txtbxAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxAddress.Location = new Point(119, 212);
            txtbxAddress.Name = "txtbxAddress";
            txtbxAddress.Size = new Size(233, 27);
            txtbxAddress.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 215);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 15;
            // 
            // txtbxContactNo
            // 
            txtbxContactNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxContactNo.Location = new Point(119, 245);
            txtbxContactNo.Name = "txtbxContactNo";
            txtbxContactNo.Size = new Size(233, 27);
            txtbxContactNo.TabIndex = 18;
            txtbxContactNo.TextChanged += txtbxContactNo_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 248);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 17;
            label7.Text = "Contact No :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 215);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 19;
            label8.Text = "Address :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(52, 282);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 20;
            label9.Text = "Email :";
            // 
            // txtbxEmail
            // 
            txtbxEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEmail.Location = new Point(119, 279);
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(233, 27);
            txtbxEmail.TabIndex = 21;
            txtbxEmail.TextChanged += txtbxEmail_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "Upload Profile";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(16, 12);
            button2.Name = "button2";
            button2.Size = new Size(22, 26);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePickerBirthdate
            // 
            dateTimePickerBirthdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerBirthdate.Location = new Point(119, 145);
            dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            dateTimePickerBirthdate.Size = new Size(233, 27);
            dateTimePickerBirthdate.TabIndex = 23;
            dateTimePickerBirthdate.ValueChanged += dateTimePickerBirthdate_ValueChanged;
            // 
            // buttonUploadImage
            // 
            buttonUploadImage.BackColor = Color.FromArgb(255, 224, 192);
            buttonUploadImage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUploadImage.Image = (Image)resources.GetObject("buttonUploadImage.Image");
            buttonUploadImage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUploadImage.Location = new Point(441, 169);
            buttonUploadImage.Name = "buttonUploadImage";
            buttonUploadImage.Size = new Size(119, 32);
            buttonUploadImage.TabIndex = 24;
            buttonUploadImage.Text = "Upload image";
            buttonUploadImage.TextAlign = ContentAlignment.MiddleRight;
            buttonUploadImage.UseVisualStyleBackColor = false;
            buttonUploadImage.Click += buttonUploadImage_Click;
            // 
            // AddingCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(611, 338);
            Controls.Add(buttonUploadImage);
            Controls.Add(dateTimePickerBirthdate);
            Controls.Add(button2);
            Controls.Add(txtbxEmail);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtbxContactNo);
            Controls.Add(label7);
            Controls.Add(txtbxAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxGender);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbxFullName);
            Controls.Add(pictureBoxImageProfile);
            Controls.Add(label1);
            Controls.Add(btnAddNewCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddingCustomerForm";
            Text = "AddingCustomerForm";
            Load += AddingCustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewCustomer;
        private Label label1;
        private PictureBox pictureBoxImageProfile;
        private TextBox txtbxFullName;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxGender;
        private Label label5;
        private TextBox txtbxAddress;
        private Label label6;
        private TextBox txtbxContactNo;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtbxEmail;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private DateTimePicker dateTimePickerBirthdate;
        private Button buttonUploadImage;
    }
}