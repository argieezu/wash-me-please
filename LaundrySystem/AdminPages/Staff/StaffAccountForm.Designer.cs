namespace LaundrySystem.AdminPages
{
    partial class StaffAccountForm
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
            btnDeletStaffAdmin = new Button();
            btnEditStaffAdmin = new Button();
            button1 = new Button();
            btnNewStaffAdmin = new Button();
            dataGridViewStaff = new DataGridView();
            label1 = new Label();
            btnSearchStaff = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDeletStaffAdmin);
            panel1.Controls.Add(btnEditStaffAdmin);
            panel1.Controls.Add(btnSearchStaff);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 437);
            panel1.TabIndex = 0;
            // 
            // btnDeletStaffAdmin
            // 
            btnDeletStaffAdmin.BackColor = Color.FromArgb(255, 128, 128);
            btnDeletStaffAdmin.Location = new Point(749, 387);
            btnDeletStaffAdmin.Name = "btnDeletStaffAdmin";
            btnDeletStaffAdmin.Size = new Size(75, 32);
            btnDeletStaffAdmin.TabIndex = 13;
            btnDeletStaffAdmin.Text = "Delete";
            btnDeletStaffAdmin.UseVisualStyleBackColor = false;
            btnDeletStaffAdmin.Click += btnDeletStaffAdmin_Click;
            // 
            // btnEditStaffAdmin
            // 
            btnEditStaffAdmin.BackColor = Color.MediumTurquoise;
            btnEditStaffAdmin.Location = new Point(749, 143);
            btnEditStaffAdmin.Name = "btnEditStaffAdmin";
            btnEditStaffAdmin.Size = new Size(75, 32);
            btnEditStaffAdmin.TabIndex = 12;
            btnEditStaffAdmin.Text = "Edit";
            btnEditStaffAdmin.UseVisualStyleBackColor = false;
            btnEditStaffAdmin.Click += btnEditStaffAdmin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Location = new Point(749, 105);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 12;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnNewStaffAdmin
            // 
            btnNewStaffAdmin.BackColor = Color.FromArgb(255, 224, 192);
            btnNewStaffAdmin.Location = new Point(749, 105);
            btnNewStaffAdmin.Name = "btnNewStaffAdmin";
            btnNewStaffAdmin.Size = new Size(75, 32);
            btnNewStaffAdmin.TabIndex = 11;
            btnNewStaffAdmin.Text = "Add";
            btnNewStaffAdmin.UseVisualStyleBackColor = false;
            btnNewStaffAdmin.Click += btnNewStaffAdmin_Click;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new Point(12, 91);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStaff.Size = new Size(731, 328);
            dataGridViewStaff.TabIndex = 10;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 9;
            label1.Text = "Staff List";
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.BackColor = Color.FromArgb(255, 224, 192);
            btnSearchStaff.Location = new Point(447, 60);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(75, 27);
            btnSearchStaff.TabIndex = 8;
            btnSearchStaff.Text = "Search";
            btnSearchStaff.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 25);
            textBox1.TabIndex = 7;
            textBox1.Text = "Search Staff";
            // 
            // StaffAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 437);
            Controls.Add(btnNewStaffAdmin);
            Controls.Add(dataGridViewStaff);
            Controls.Add(panel1);
            Name = "StaffAccountForm";
            Text = "CreateAccount";
            Load += StaffAccountForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDeletStaffAdmin;
        private Button btnEditStaffAdmin;
        private Button btnNewStaffAdmin;
        private DataGridView dataGridViewStaff;
        private Label label1;
        private Button btnSearchStaff;
        private TextBox textBox1;
        private Button button1;
    }
}