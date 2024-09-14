namespace LaundrySystem
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            panel1 = new Panel();
            button1 = new Button();
            btnDashboard = new Button();
            btnCategory = new Button();
            btnRelease = new Button();
            btnTransaction = new Button();
            btnAccount = new Button();
            pictureBox1 = new PictureBox();
            upperPanel = new Panel();
            lblNamePages = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            upperPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnRelease);
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 577);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 496);
            button1.Name = "button1";
            button1.Size = new Size(153, 50);
            button1.TabIndex = 7;
            button1.Text = "Logout ni ya";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightSkyBlue;
            btnDashboard.Location = new Point(12, 160);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(153, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.LightSkyBlue;
            btnCategory.Location = new Point(12, 384);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(153, 50);
            btnCategory.TabIndex = 5;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnRelease
            // 
            btnRelease.BackColor = Color.LightSkyBlue;
            btnRelease.Location = new Point(12, 328);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(153, 50);
            btnRelease.TabIndex = 4;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = false;
            btnRelease.Click += btnRelease_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.LightSkyBlue;
            btnTransaction.Location = new Point(12, 272);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(153, 50);
            btnTransaction.TabIndex = 3;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.LightSkyBlue;
            btnAccount.Location = new Point(12, 216);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(153, 50);
            btnAccount.TabIndex = 2;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // upperPanel
            // 
            upperPanel.BackColor = SystemColors.GradientActiveCaption;
            upperPanel.Controls.Add(lblNamePages);
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Location = new Point(178, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(760, 89);
            upperPanel.TabIndex = 3;
            upperPanel.Paint += upperPanel_Paint;
            // 
            // lblNamePages
            // 
            lblNamePages.AutoSize = true;
            lblNamePages.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamePages.Location = new Point(29, 22);
            lblNamePages.Name = "lblNamePages";
            lblNamePages.Size = new Size(84, 32);
            lblNamePages.TabIndex = 0;
            lblNamePages.Text = "Home";
            lblNamePages.Click += lblNamePages_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(178, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(760, 488);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(215, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 320);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(938, 577);
            Controls.Add(panel3);
            Controls.Add(upperPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            upperPanel.ResumeLayout(false);
            upperPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnDashboard;
        private Panel upperPanel;
        private Button btnRelease;
        private Button btnTransaction;
        private Button btnAccount;
        private Button btnCategory;
        private Button button1;
        private Panel panel3;
        private Label lblNamePages;
        private PictureBox pictureBox2;
    }
}