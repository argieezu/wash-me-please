namespace LaundrySystem.auth_pages
{
    partial class CustomerRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegisterForm));
            label4 = new Label();
            btnLoginNow = new Button();
            btnCustomerRegister = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 345);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 21;
            label4.Text = "Don't have account?";
            // 
            // btnLoginNow
            // 
            btnLoginNow.FlatAppearance.BorderSize = 0;
            btnLoginNow.FlatStyle = FlatStyle.Flat;
            btnLoginNow.ForeColor = Color.Blue;
            btnLoginNow.Location = new Point(432, 341);
            btnLoginNow.Name = "btnLoginNow";
            btnLoginNow.Size = new Size(121, 23);
            btnLoginNow.TabIndex = 20;
            btnLoginNow.Text = "Login now";
            btnLoginNow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoginNow.UseVisualStyleBackColor = true;
            btnLoginNow.Click += btnLoginNow_Click;
            // 
            // btnCustomerRegister
            // 
            btnCustomerRegister.BackColor = Color.PaleGreen;
            btnCustomerRegister.FlatAppearance.BorderSize = 0;
            btnCustomerRegister.FlatStyle = FlatStyle.Flat;
            btnCustomerRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerRegister.Location = new Point(347, 259);
            btnCustomerRegister.Name = "btnCustomerRegister";
            btnCustomerRegister.Size = new Size(192, 37);
            btnCustomerRegister.TabIndex = 19;
            btnCustomerRegister.Text = "Register";
            btnCustomerRegister.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(347, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 29);
            textBox2.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 166);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 16;
            label3.Text = "Password : ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(347, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 29);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 123);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 14;
            label2.Text = "Username : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 37);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 13;
            label1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-53, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(606, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(347, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 29);
            textBox3.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(188, 211);
            label5.Name = "label5";
            label5.Size = new Size(160, 21);
            label5.TabIndex = 24;
            label5.Text = "Confirm Password : ";
            // 
            // CustomerRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(584, 450);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(btnLoginNow);
            Controls.Add(btnCustomerRegister);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "CustomerRegisterForm";
            Text = "CustomerRegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button btnLoginNow;
        private Button btnCustomerRegister;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Label label5;
    }
}