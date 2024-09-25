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
            btnLoginAdminToHomePage = new Button();
            txtbxUsernameAdmin = new TextBox();
            txtbxPasswordAdmin = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            buttonBackToAdminOrStaff = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLoginAdminToHomePage
            // 
            btnLoginAdminToHomePage.BackColor = Color.FromArgb(255, 192, 128);
            btnLoginAdminToHomePage.FlatAppearance.BorderSize = 0;
            btnLoginAdminToHomePage.FlatStyle = FlatStyle.Flat;
            btnLoginAdminToHomePage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginAdminToHomePage.Location = new Point(248, 213);
            btnLoginAdminToHomePage.Name = "btnLoginAdminToHomePage";
            btnLoginAdminToHomePage.Size = new Size(202, 33);
            btnLoginAdminToHomePage.TabIndex = 3;
            btnLoginAdminToHomePage.Text = "Login";
            btnLoginAdminToHomePage.UseVisualStyleBackColor = false;
            btnLoginAdminToHomePage.Click += btnLoginAdminToHomePage_Click;
            // 
            // txtbxUsernameAdmin
            // 
            txtbxUsernameAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUsernameAdmin.Location = new Point(251, 93);
            txtbxUsernameAdmin.Name = "txtbxUsernameAdmin";
            txtbxUsernameAdmin.PlaceholderText = "username";
            txtbxUsernameAdmin.Size = new Size(202, 29);
            txtbxUsernameAdmin.TabIndex = 4;
            // 
            // txtbxPasswordAdmin
            // 
            txtbxPasswordAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPasswordAdmin.Location = new Point(248, 141);
            txtbxPasswordAdmin.Name = "txtbxPasswordAdmin";
            txtbxPasswordAdmin.PasswordChar = '*';
            txtbxPasswordAdmin.PlaceholderText = "password";
            txtbxPasswordAdmin.Size = new Size(202, 29);
            txtbxPasswordAdmin.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 10);
            label3.Name = "label3";
            label3.Size = new Size(193, 40);
            label3.TabIndex = 6;
            label3.Text = "Admin Login";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonBackToAdminOrStaff);
            panel1.Controls.Add(txtbxPasswordAdmin);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.admin__2_;
            pictureBox1.Location = new Point(20, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 153);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(208, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.avatar__1_;
            pictureBox3.Location = new Point(208, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 30);
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoginAdminToHomePage;
        private TextBox txtbxUsernameAdmin;
        private TextBox txtbxPasswordAdmin;
        private Label label3;
        private Panel panel1;
        private Button buttonBackToAdminOrStaff;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}