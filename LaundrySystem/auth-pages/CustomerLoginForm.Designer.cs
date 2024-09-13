namespace LaundrySystem.auth_pages
{
    partial class CustomerLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtbxUsernameCustomer = new TextBox();
            bxbxtPasswordCustomer = new TextBox();
            label3 = new Label();
            btnForgotPassword = new Button();
            btnCustomerLogin = new Button();
            btnRegisterNow = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-55, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(606, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 123);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 2;
            label2.Text = "Username : ";
            // 
            // txtbxUsernameCustomer
            // 
            txtbxUsernameCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUsernameCustomer.Location = new Point(336, 120);
            txtbxUsernameCustomer.Name = "txtbxUsernameCustomer";
            txtbxUsernameCustomer.Size = new Size(192, 29);
            txtbxUsernameCustomer.TabIndex = 3;
            // 
            // bxbxtPasswordCustomer
            // 
            bxbxtPasswordCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxbxtPasswordCustomer.Location = new Point(336, 163);
            bxbxtPasswordCustomer.Name = "bxbxtPasswordCustomer";
            bxbxtPasswordCustomer.PasswordChar = '*';
            bxbxtPasswordCustomer.Size = new Size(192, 29);
            bxbxtPasswordCustomer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 166);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 4;
            label3.Text = "Password : ";
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.FlatAppearance.BorderSize = 0;
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.ForeColor = Color.Blue;
            btnForgotPassword.Location = new Point(419, 198);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(121, 23);
            btnForgotPassword.TabIndex = 6;
            btnForgotPassword.Text = "Forgot Password";
            btnForgotPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.BackColor = Color.PaleGreen;
            btnCustomerLogin.FlatAppearance.BorderSize = 0;
            btnCustomerLogin.FlatStyle = FlatStyle.Flat;
            btnCustomerLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerLogin.Location = new Point(336, 247);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(192, 30);
            btnCustomerLogin.TabIndex = 7;
            btnCustomerLogin.Text = "Login";
            btnCustomerLogin.UseVisualStyleBackColor = false;
            btnCustomerLogin.Click += btnCustomerLogin_Click;
            // 
            // btnRegisterNow
            // 
            btnRegisterNow.FlatAppearance.BorderSize = 0;
            btnRegisterNow.FlatStyle = FlatStyle.Flat;
            btnRegisterNow.ForeColor = Color.Blue;
            btnRegisterNow.Location = new Point(445, 319);
            btnRegisterNow.Name = "btnRegisterNow";
            btnRegisterNow.Size = new Size(83, 23);
            btnRegisterNow.TabIndex = 8;
            btnRegisterNow.Text = "Register now";
            btnRegisterNow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegisterNow.UseVisualStyleBackColor = true;
            btnRegisterNow.Click += btnRegisterNow_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 323);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 9;
            label4.Text = "Don't have account?";
            // 
            // CustomerLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(584, 450);
            Controls.Add(label4);
            Controls.Add(btnRegisterNow);
            Controls.Add(btnCustomerLogin);
            Controls.Add(btnForgotPassword);
            Controls.Add(bxbxtPasswordCustomer);
            Controls.Add(label3);
            Controls.Add(txtbxUsernameCustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "CustomerLoginForm";
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
        private Button btnForgotPassword;
        private Button btnCustomerLogin;
        private Button btnRegisterNow;
        private Label label4;
    }
}