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
            label1 = new Label();
            label2 = new Label();
            btnLoginAdminToHomePage = new Button();
            txtbxUsernameAdmin = new TextBox();
            txtbxPasswordAdmin = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 69);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 1;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 111);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // btnLoginAdminToHomePage
            // 
            btnLoginAdminToHomePage.BackColor = Color.FromArgb(255, 192, 128);
            btnLoginAdminToHomePage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginAdminToHomePage.Location = new Point(123, 176);
            btnLoginAdminToHomePage.Name = "btnLoginAdminToHomePage";
            btnLoginAdminToHomePage.Size = new Size(231, 31);
            btnLoginAdminToHomePage.TabIndex = 3;
            btnLoginAdminToHomePage.Text = "Login";
            btnLoginAdminToHomePage.UseVisualStyleBackColor = false;
            btnLoginAdminToHomePage.Click += btnLoginAdminToHomePage_Click;
            // 
            // txtbxUsernameAdmin
            // 
            txtbxUsernameAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUsernameAdmin.Location = new Point(123, 66);
            txtbxUsernameAdmin.Name = "txtbxUsernameAdmin";
            txtbxUsernameAdmin.Size = new Size(231, 29);
            txtbxUsernameAdmin.TabIndex = 4;
            // 
            // txtbxPasswordAdmin
            // 
            txtbxPasswordAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPasswordAdmin.Location = new Point(123, 111);
            txtbxPasswordAdmin.Name = "txtbxPasswordAdmin";
            txtbxPasswordAdmin.PasswordChar = '*';
            txtbxPasswordAdmin.Size = new Size(231, 29);
            txtbxPasswordAdmin.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 9);
            label3.Name = "label3";
            label3.Size = new Size(181, 37);
            label3.TabIndex = 6;
            label3.Text = "Admin Login";
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(402, 239);
            Controls.Add(label3);
            Controls.Add(txtbxPasswordAdmin);
            Controls.Add(txtbxUsernameAdmin);
            Controls.Add(btnLoginAdminToHomePage);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnLoginAdminToHomePage;
        private TextBox txtbxUsernameAdmin;
        private TextBox txtbxPasswordAdmin;
        private Label label3;
    }
}