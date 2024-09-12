namespace LaundrySystem
{
    partial class StaffLoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLoginForm));
            panel3 = new Panel();
            btnStaffLogin = new Button();
            txtbxStaffPassword = new TextBox();
            txtbxStaffUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(btnStaffLogin);
            panel3.Controls.Add(txtbxStaffPassword);
            panel3.Controls.Add(txtbxStaffUsername);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 255);
            panel3.TabIndex = 3;
            // 
            // btnStaffLogin
            // 
            btnStaffLogin.BackColor = SystemColors.GradientActiveCaption;
            btnStaffLogin.FlatAppearance.BorderSize = 0;
            btnStaffLogin.FlatStyle = FlatStyle.Flat;
            btnStaffLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffLogin.Location = new Point(113, 211);
            btnStaffLogin.Name = "btnStaffLogin";
            btnStaffLogin.Size = new Size(156, 32);
            btnStaffLogin.TabIndex = 5;
            btnStaffLogin.Text = "Login now";
            btnStaffLogin.UseVisualStyleBackColor = false;
            btnStaffLogin.Click += btnStaffLogin_Click;
            // 
            // txtbxStaffPassword
            // 
            txtbxStaffPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxStaffPassword.Location = new Point(113, 158);
            txtbxStaffPassword.Name = "txtbxStaffPassword";
            txtbxStaffPassword.Size = new Size(156, 29);
            txtbxStaffPassword.TabIndex = 3;
            // 
            // txtbxStaffUsername
            // 
            txtbxStaffUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxStaffUsername.Location = new Point(113, 110);
            txtbxStaffUsername.Name = "txtbxStaffUsername";
            txtbxStaffUsername.Size = new Size(156, 29);
            txtbxStaffUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 161);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 1;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 113);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 0;
            label2.Text = "Username :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // StaffLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 255);
            Controls.Add(panel3);
            Name = "StaffLoginForm";
            Text = "Staff Login";
            Load += StaffLoginForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtbxStaffPassword;
        private TextBox txtbxStaffUsername;
        private Button btnStaffLogin;
    }
}
