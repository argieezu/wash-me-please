namespace LaundrySystem.AdminPages
{
    partial class CustomerFormAdmin
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
            panel1 = new Panel();
            btnDeleteCustomerAdmin = new Button();
            btnEditCustomerAdmin = new Button();
            btnNewCustomerAdmin = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnSearchCustomer = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDeleteCustomerAdmin);
            panel1.Controls.Add(btnEditCustomerAdmin);
            panel1.Controls.Add(btnNewCustomerAdmin);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearchCustomer);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 437);
            panel1.TabIndex = 0;
            // 
            // btnDeleteCustomerAdmin
            // 
            btnDeleteCustomerAdmin.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteCustomerAdmin.Location = new Point(751, 174);
            btnDeleteCustomerAdmin.Name = "btnDeleteCustomerAdmin";
            btnDeleteCustomerAdmin.Size = new Size(75, 32);
            btnDeleteCustomerAdmin.TabIndex = 6;
            btnDeleteCustomerAdmin.Text = "Delete";
            btnDeleteCustomerAdmin.UseVisualStyleBackColor = false;
            // 
            // btnEditCustomerAdmin
            // 
            btnEditCustomerAdmin.BackColor = Color.MediumTurquoise;
            btnEditCustomerAdmin.Location = new Point(751, 136);
            btnEditCustomerAdmin.Name = "btnEditCustomerAdmin";
            btnEditCustomerAdmin.Size = new Size(75, 32);
            btnEditCustomerAdmin.TabIndex = 5;
            btnEditCustomerAdmin.Text = "Edit";
            btnEditCustomerAdmin.UseVisualStyleBackColor = false;
            // 
            // btnNewCustomerAdmin
            // 
            btnNewCustomerAdmin.BackColor = Color.FromArgb(255, 224, 192);
            btnNewCustomerAdmin.Location = new Point(751, 98);
            btnNewCustomerAdmin.Name = "btnNewCustomerAdmin";
            btnNewCustomerAdmin.Size = new Size(75, 32);
            btnNewCustomerAdmin.TabIndex = 4;
            btnNewCustomerAdmin.Text = "Add";
            btnNewCustomerAdmin.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(716, 314);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 2;
            label1.Text = "Customer List";
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.FromArgb(255, 224, 192);
            btnSearchCustomer.Location = new Point(464, 53);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(75, 27);
            btnSearchCustomer.TabIndex = 1;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 25);
            textBox1.TabIndex = 0;
            textBox1.Text = "Search Customer";
            // 
            // CustomerFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 437);
            Controls.Add(panel1);
            Name = "CustomerFormAdmin";
            Text = "CustomerFormAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSearchCustomer;
        private TextBox textBox1;
        private Button btnDeleteCustomerAdmin;
        private Button btnEditCustomerAdmin;
        private Button btnNewCustomerAdmin;
        private DataGridView dataGridView1;
    }
}