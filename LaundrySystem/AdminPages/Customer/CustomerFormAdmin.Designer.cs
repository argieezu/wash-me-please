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
            dataGridViewDisplayCustomer = new DataGridView();
            label1 = new Label();
            btnSearchCustomer = new Button();
            textBoxSearchCustomer = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisplayCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDeleteCustomerAdmin);
            panel1.Controls.Add(btnEditCustomerAdmin);
            panel1.Controls.Add(btnNewCustomerAdmin);
            panel1.Controls.Add(dataGridViewDisplayCustomer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearchCustomer);
            panel1.Controls.Add(textBoxSearchCustomer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 437);
            panel1.TabIndex = 0;
            // 
            // btnDeleteCustomerAdmin
            // 
            btnDeleteCustomerAdmin.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteCustomerAdmin.Image = Properties.Resources.bin__1_;
            btnDeleteCustomerAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteCustomerAdmin.Location = new Point(751, 380);
            btnDeleteCustomerAdmin.Name = "btnDeleteCustomerAdmin";
            btnDeleteCustomerAdmin.Size = new Size(84, 32);
            btnDeleteCustomerAdmin.TabIndex = 6;
            btnDeleteCustomerAdmin.Text = "Delete";
            btnDeleteCustomerAdmin.UseVisualStyleBackColor = false;
            btnDeleteCustomerAdmin.Click += btnDeleteCustomerAdmin_Click;
            // 
            // btnEditCustomerAdmin
            // 
            btnEditCustomerAdmin.BackColor = Color.FromArgb(192, 255, 255);
            btnEditCustomerAdmin.Image = Properties.Resources.edit;
            btnEditCustomerAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditCustomerAdmin.Location = new Point(751, 136);
            btnEditCustomerAdmin.Name = "btnEditCustomerAdmin";
            btnEditCustomerAdmin.Size = new Size(84, 32);
            btnEditCustomerAdmin.TabIndex = 5;
            btnEditCustomerAdmin.Text = "Edit";
            btnEditCustomerAdmin.UseVisualStyleBackColor = false;
            // 
            // btnNewCustomerAdmin
            // 
            btnNewCustomerAdmin.BackColor = Color.FromArgb(192, 255, 192);
            btnNewCustomerAdmin.Image = Properties.Resources.add_user;
            btnNewCustomerAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewCustomerAdmin.Location = new Point(751, 98);
            btnNewCustomerAdmin.Name = "btnNewCustomerAdmin";
            btnNewCustomerAdmin.Size = new Size(84, 32);
            btnNewCustomerAdmin.TabIndex = 4;
            btnNewCustomerAdmin.Text = "Add";
            btnNewCustomerAdmin.UseVisualStyleBackColor = false;
            btnNewCustomerAdmin.Click += btnNewCustomerAdmin_Click;
            // 
            // dataGridViewDisplayCustomer
            // 
            dataGridViewDisplayCustomer.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewDisplayCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDisplayCustomer.Location = new Point(12, 98);
            dataGridViewDisplayCustomer.Name = "dataGridViewDisplayCustomer";
            dataGridViewDisplayCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDisplayCustomer.Size = new Size(733, 314);
            dataGridViewDisplayCustomer.TabIndex = 3;
            dataGridViewDisplayCustomer.CellContentClick += dataGridViewDisplayCustomer_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 2;
            label1.Text = "Customer List";
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.FromArgb(255, 224, 192);
            btnSearchCustomer.Image = Properties.Resources.loupe;
            btnSearchCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCustomer.Location = new Point(464, 65);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(71, 27);
            btnSearchCustomer.TabIndex = 1;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearchCustomer.Location = new Point(12, 65);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.Size = new Size(446, 25);
            textBoxSearchCustomer.TabIndex = 0;
            textBoxSearchCustomer.Text = "Search Customer";
            textBoxSearchCustomer.TextChanged += textBoxSearchCustomer_TextChanged;
            // 
            // CustomerFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 437);
            Controls.Add(panel1);
            Name = "CustomerFormAdmin";
            Text = "CustomerFormAdmin";
            Load += CustomerFormAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisplayCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSearchCustomer;
        private TextBox textBoxSearchCustomer;
        private Button btnDeleteCustomerAdmin;
        private Button btnEditCustomerAdmin;
        private Button btnNewCustomerAdmin;
        private DataGridView dataGridViewDisplayCustomer;
 
    }
}