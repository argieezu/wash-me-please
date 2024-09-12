namespace LaundrySystem
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            panel1 = new Panel();
            button1 = new Button();
            button4 = new Button();
            btnDashboard = new Button();
            btnCategory = new Button();
            btnRelease = new Button();
            btnTransaction = new Button();
            btnAccount = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
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
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Location = new Point(12, 440);
            button4.Name = "button4";
            button4.Size = new Size(153, 50);
            button4.TabIndex = 6;
            button4.Text = "MAMA MO BLUE";
            button4.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(178, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 89);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(178, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 488);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 577);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnDashboard;
        private Panel panel2;
        private Button btnRelease;
        private Button btnTransaction;
        private Button btnAccount;
        private Button button4;
        private Button btnCategory;
        private Button button1;
        private Panel panel3;
    }
}