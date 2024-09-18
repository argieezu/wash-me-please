namespace LaundrySystem.auth_pages
{
    partial class AdminOrStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrStaff));
            btnAdminRouteLogin = new Button();
            panel3 = new Panel();
            btnStaffRouteLogin = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdminRouteLogin
            // 
            btnAdminRouteLogin.BackColor = Color.RosyBrown;
            btnAdminRouteLogin.FlatAppearance.BorderSize = 0;
            btnAdminRouteLogin.FlatStyle = FlatStyle.Flat;
            btnAdminRouteLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminRouteLogin.Image = (Image)resources.GetObject("btnAdminRouteLogin.Image");
            btnAdminRouteLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminRouteLogin.Location = new Point(47, 60);
            btnAdminRouteLogin.Name = "btnAdminRouteLogin";
            btnAdminRouteLogin.Size = new Size(188, 67);
            btnAdminRouteLogin.TabIndex = 0;
            btnAdminRouteLogin.Text = " Admin";
            btnAdminRouteLogin.TextAlign = ContentAlignment.MiddleRight;
            btnAdminRouteLogin.UseVisualStyleBackColor = false;
            btnAdminRouteLogin.Click += btnAdminRouteLogin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(btnAdminRouteLogin);
            panel3.Controls.Add(btnStaffRouteLogin);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 181);
            panel3.TabIndex = 2;
            // 
            // btnStaffRouteLogin
            // 
            btnStaffRouteLogin.BackColor = Color.IndianRed;
            btnStaffRouteLogin.FlatAppearance.BorderSize = 0;
            btnStaffRouteLogin.FlatStyle = FlatStyle.Flat;
            btnStaffRouteLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffRouteLogin.Image = (Image)resources.GetObject("btnStaffRouteLogin.Image");
            btnStaffRouteLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaffRouteLogin.Location = new Point(309, 60);
            btnStaffRouteLogin.Name = "btnStaffRouteLogin";
            btnStaffRouteLogin.Size = new Size(175, 67);
            btnStaffRouteLogin.TabIndex = 1;
            btnStaffRouteLogin.Text = "Staff";
            btnStaffRouteLogin.TextAlign = ContentAlignment.MiddleRight;
            btnStaffRouteLogin.UseVisualStyleBackColor = false;
            btnStaffRouteLogin.Click += btnStaffRouteLogin_Click;
            // 
            // AdminOrStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 181);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminOrStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminOrStaff";
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button btnAdminRouteLogin;
        private Button btnStaffRouteLogin;
    }
}