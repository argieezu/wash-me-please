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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnAdminRouteLogin = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            btnStaffRouteLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAdminRouteLogin);
            panel1.Location = new Point(40, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 66);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAdminRouteLogin
            // 
            btnAdminRouteLogin.BackColor = Color.RosyBrown;
            btnAdminRouteLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminRouteLogin.Location = new Point(69, -1);
            btnAdminRouteLogin.Name = "btnAdminRouteLogin";
            btnAdminRouteLogin.Size = new Size(171, 67);
            btnAdminRouteLogin.TabIndex = 0;
            btnAdminRouteLogin.Text = "Admin";
            btnAdminRouteLogin.UseVisualStyleBackColor = false;
            btnAdminRouteLogin.Click += btnAdminRouteLogin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(606, 217);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnStaffRouteLogin);
            panel2.Location = new Point(313, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 66);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnStaffRouteLogin
            // 
            btnStaffRouteLogin.BackColor = Color.IndianRed;
            btnStaffRouteLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffRouteLogin.Location = new Point(66, 0);
            btnStaffRouteLogin.Name = "btnStaffRouteLogin";
            btnStaffRouteLogin.Size = new Size(175, 66);
            btnStaffRouteLogin.TabIndex = 1;
            btnStaffRouteLogin.Text = "Staff";
            btnStaffRouteLogin.UseVisualStyleBackColor = false;
            btnStaffRouteLogin.Click += btnStaffRouteLogin_Click;
            // 
            // AdminOrStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 217);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "AdminOrStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminOrStaff";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnAdminRouteLogin;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnStaffRouteLogin;
    }
}