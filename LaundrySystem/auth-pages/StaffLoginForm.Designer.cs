namespace LaundrySystem.auth_pages
{
    partial class StaffLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtbxUsernameCustomer = new TextBox();
            bxbxtPasswordCustomer = new TextBox();
            label3 = new Label();
            btnCustomerLogin = new Button();
            buttonStaffBackToAdminOrStaff = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-52, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(606, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 91);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 2;
            label2.Text = "Username : ";
            // 
            // txtbxUsernameCustomer
            // 
            txtbxUsernameCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUsernameCustomer.Location = new Point(336, 88);
            txtbxUsernameCustomer.Name = "txtbxUsernameCustomer";
            txtbxUsernameCustomer.Size = new Size(192, 29);
            txtbxUsernameCustomer.TabIndex = 3;
            // 
            // bxbxtPasswordCustomer
            // 
            bxbxtPasswordCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxbxtPasswordCustomer.Location = new Point(336, 126);
            bxbxtPasswordCustomer.Name = "bxbxtPasswordCustomer";
            bxbxtPasswordCustomer.PasswordChar = '*';
            bxbxtPasswordCustomer.Size = new Size(192, 29);
            bxbxtPasswordCustomer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 129);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 4;
            label3.Text = "Password : ";
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.BackColor = Color.PaleGreen;
            btnCustomerLogin.FlatAppearance.BorderSize = 0;
            btnCustomerLogin.FlatStyle = FlatStyle.Flat;
            btnCustomerLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerLogin.Location = new Point(336, 222);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(192, 38);
            btnCustomerLogin.TabIndex = 7;
            btnCustomerLogin.Text = "Login";
            btnCustomerLogin.UseVisualStyleBackColor = false;
            btnCustomerLogin.Click += btnCustomerLogin_Click;
            // 
            // buttonStaffBackToAdminOrStaff
            // 
            buttonStaffBackToAdminOrStaff.FlatAppearance.BorderSize = 0;
            buttonStaffBackToAdminOrStaff.FlatStyle = FlatStyle.Flat;
            buttonStaffBackToAdminOrStaff.Image = (Image)resources.GetObject("buttonStaffBackToAdminOrStaff.Image");
            buttonStaffBackToAdminOrStaff.Location = new Point(12, 12);
            buttonStaffBackToAdminOrStaff.Name = "buttonStaffBackToAdminOrStaff";
            buttonStaffBackToAdminOrStaff.Size = new Size(22, 26);
            buttonStaffBackToAdminOrStaff.TabIndex = 24;
            buttonStaffBackToAdminOrStaff.UseVisualStyleBackColor = true;
            buttonStaffBackToAdminOrStaff.Click += buttonStaffBackToAdminOrStaff_Click;
            // 
            // StaffLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(550, 308);
            Controls.Add(buttonStaffBackToAdminOrStaff);
            Controls.Add(btnCustomerLogin);
            Controls.Add(bxbxtPasswordCustomer);
            Controls.Add(label3);
            Controls.Add(txtbxUsernameCustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerLoginForm";
            Load += CustomerLoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtbxUsernameCustomer;
        private TextBox bxbxtPasswordCustomer;
        private Label label3;
        private Button btnCustomerLogin;
        private Button buttonStaffBackToAdminOrStaff;
    }
}