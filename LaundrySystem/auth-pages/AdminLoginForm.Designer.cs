namespace LaundrySystem.auth_pages
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            label2 = new Label();
            btnLoginAdminToHomePage = new Button();
            txtbxUsernameAdmin = new TextBox();
            txtbxPasswordAdmin = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            buttonBackToAdminOrStaff = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 135);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // btnLoginAdminToHomePage
            // 
            btnLoginAdminToHomePage.BackColor = Color.FromArgb(192, 255, 255);
            btnLoginAdminToHomePage.FlatAppearance.BorderSize = 0;
            btnLoginAdminToHomePage.FlatStyle = FlatStyle.Flat;
            btnLoginAdminToHomePage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginAdminToHomePage.Location = new Point(139, 212);
            btnLoginAdminToHomePage.Name = "btnLoginAdminToHomePage";
            btnLoginAdminToHomePage.Size = new Size(231, 46);
            btnLoginAdminToHomePage.TabIndex = 3;
            btnLoginAdminToHomePage.Text = "Login";
            btnLoginAdminToHomePage.UseVisualStyleBackColor = false;
            btnLoginAdminToHomePage.Click += btnLoginAdminToHomePage_Click;
            // 
            // txtbxUsernameAdmin
            // 
            txtbxUsernameAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUsernameAdmin.Location = new Point(139, 96);
            txtbxUsernameAdmin.Name = "txtbxUsernameAdmin";
            txtbxUsernameAdmin.Size = new Size(231, 29);
            txtbxUsernameAdmin.TabIndex = 4;
            // 
            // txtbxPasswordAdmin
            // 
            txtbxPasswordAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPasswordAdmin.Location = new Point(139, 135);
            txtbxPasswordAdmin.Name = "txtbxPasswordAdmin";
            txtbxPasswordAdmin.PasswordChar = '*';
            txtbxPasswordAdmin.Size = new Size(231, 29);
            txtbxPasswordAdmin.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 18);
            label3.Name = "label3";
            label3.Size = new Size(193, 40);
            label3.TabIndex = 6;
            label3.Text = "Admin Login";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonBackToAdminOrStaff);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbxPasswordAdmin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtbxUsernameAdmin);
            panel1.Controls.Add(btnLoginAdminToHomePage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 272);
            panel1.TabIndex = 7;
            // 
            // buttonBackToAdminOrStaff
            // 
            buttonBackToAdminOrStaff.FlatAppearance.BorderSize = 0;
            buttonBackToAdminOrStaff.FlatStyle = FlatStyle.Flat;
            buttonBackToAdminOrStaff.Image = (Image)resources.GetObject("buttonBackToAdminOrStaff.Image");
            buttonBackToAdminOrStaff.Location = new Point(10, 10);
            buttonBackToAdminOrStaff.Name = "buttonBackToAdminOrStaff";
            buttonBackToAdminOrStaff.Size = new Size(22, 26);
            buttonBackToAdminOrStaff.TabIndex = 23;
            buttonBackToAdminOrStaff.UseVisualStyleBackColor = true;
            buttonBackToAdminOrStaff.Click += buttonBackToAdminOrStaff_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 96);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 8;
            label1.Text = "Username :";
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(474, 272);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button btnLoginAdminToHomePage;
        private TextBox txtbxUsernameAdmin;
        private TextBox txtbxPasswordAdmin;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Button buttonBackToAdminOrStaff;
    }
}