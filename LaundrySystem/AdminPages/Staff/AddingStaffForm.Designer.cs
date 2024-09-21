namespace LaundrySystem.AdminPages.Staff
{
    partial class AddingStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingStaffForm));
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            dateTimePickerBirthdateStaff = new DateTimePicker();
            txtbxEmailSTAFF = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtbxContactNoStaff = new TextBox();
            label7 = new Label();
            txtbxAddressStaff = new TextBox();
            label6 = new Label();
            label5 = new Label();
            comboBoxGenderStaff = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtbxFullNameStaff = new TextBox();
            label1 = new Label();
            btnAddNewStaff = new Button();
            textBoxUsernameStaff = new TextBox();
            label4 = new Label();
            textBoxPasswordStaff = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(22, 26);
            button2.TabIndex = 40;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "Upload Profile";
            // 
            // dateTimePickerBirthdateStaff
            // 
            dateTimePickerBirthdateStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerBirthdateStaff.Location = new Point(115, 114);
            dateTimePickerBirthdateStaff.Name = "dateTimePickerBirthdateStaff";
            dateTimePickerBirthdateStaff.Size = new Size(233, 27);
            dateTimePickerBirthdateStaff.TabIndex = 41;
            // 
            // txtbxEmailSTAFF
            // 
            txtbxEmailSTAFF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEmailSTAFF.Location = new Point(115, 248);
            txtbxEmailSTAFF.Name = "txtbxEmailSTAFF";
            txtbxEmailSTAFF.Size = new Size(233, 27);
            txtbxEmailSTAFF.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(49, 249);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 38;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 182);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 37;
            label8.Text = "Address :";
            // 
            // txtbxContactNoStaff
            // 
            txtbxContactNoStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxContactNoStaff.Location = new Point(115, 214);
            txtbxContactNoStaff.Name = "txtbxContactNoStaff";
            txtbxContactNoStaff.Size = new Size(233, 27);
            txtbxContactNoStaff.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 215);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 35;
            label7.Text = "Contact No :";
            // 
            // txtbxAddressStaff
            // 
            txtbxAddressStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxAddressStaff.Location = new Point(115, 181);
            txtbxAddressStaff.Name = "txtbxAddressStaff";
            txtbxAddressStaff.Size = new Size(233, 27);
            txtbxAddressStaff.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 184);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(158, 9);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 32;
            label5.Text = "Add Staff";
            // 
            // comboBoxGenderStaff
            // 
            comboBoxGenderStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGenderStaff.FormattingEnabled = true;
            comboBoxGenderStaff.Items.AddRange(new object[] { "Male", "Female", "Email", "Transgender" });
            comboBoxGenderStaff.Location = new Point(115, 147);
            comboBoxGenderStaff.Name = "comboBoxGenderStaff";
            comboBoxGenderStaff.Size = new Size(233, 28);
            comboBoxGenderStaff.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 150);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 30;
            label3.Text = "Gender :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 118);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 29;
            label2.Text = "Birthdate :";
            // 
            // txtbxFullNameStaff
            // 
            txtbxFullNameStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxFullNameStaff.Location = new Point(115, 81);
            txtbxFullNameStaff.Name = "txtbxFullNameStaff";
            txtbxFullNameStaff.Size = new Size(233, 27);
            txtbxFullNameStaff.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 82);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 26;
            label1.Text = "Fullname :";
            // 
            // btnAddNewStaff
            // 
            btnAddNewStaff.BackColor = Color.FromArgb(192, 255, 192);
            btnAddNewStaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewStaff.Image = Properties.Resources.add_user;
            btnAddNewStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewStaff.Location = new Point(115, 380);
            btnAddNewStaff.Name = "btnAddNewStaff";
            btnAddNewStaff.Size = new Size(233, 39);
            btnAddNewStaff.TabIndex = 25;
            btnAddNewStaff.Text = "Add";
            btnAddNewStaff.UseVisualStyleBackColor = false;
            btnAddNewStaff.Click += btnAddNewStaff_Click_1;
            // 
            // textBoxUsernameStaff
            // 
            textBoxUsernameStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsernameStaff.Location = new Point(115, 285);
            textBoxUsernameStaff.Name = "textBoxUsernameStaff";
            textBoxUsernameStaff.Size = new Size(233, 27);
            textBoxUsernameStaff.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 286);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 42;
            label4.Text = "Username :";
            // 
            // textBoxPasswordStaff
            // 
            textBoxPasswordStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPasswordStaff.Location = new Point(115, 318);
            textBoxPasswordStaff.Name = "textBoxPasswordStaff";
            textBoxPasswordStaff.Size = new Size(233, 27);
            textBoxPasswordStaff.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 319);
            label10.Name = "label10";
            label10.Size = new Size(81, 20);
            label10.TabIndex = 44;
            label10.Text = "Password :";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 450);
            panel1.TabIndex = 46;
            // 
            // AddingStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(395, 450);
            Controls.Add(textBoxPasswordStaff);
            Controls.Add(textBoxUsernameStaff);
            Controls.Add(button2);
            Controls.Add(dateTimePickerBirthdateStaff);
            Controls.Add(txtbxEmailSTAFF);
            Controls.Add(txtbxContactNoStaff);
            Controls.Add(txtbxAddressStaff);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxGenderStaff);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbxFullNameStaff);
            Controls.Add(btnAddNewStaff);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddingStaffForm";
            Text = "AddStaffForm";
            Load += AddingStaffForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dateTimePickerBirthdateStaff;
        private TextBox txtbxEmailSTAFF;
        private Label label9;
        private Label label8;
        private TextBox txtbxContactNoStaff;
        private Label label7;
        private TextBox txtbxAddressStaff;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxGenderStaff;
        private Label label3;
        private Label label2;
        private TextBox txtbxFullNameStaff;
        private Label label1;
        private Button btnAddNewStaff;
        private TextBox textBoxUsernameStaff;
        private Label label4;
        private TextBox textBoxPasswordStaff;
        private Label label10;
        private Panel panel1;
    }
}