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
            btnSearchStaff = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnNewStaffAdmin = new Button();
            dataGridViewStaff = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnNewStaffAdmin);
            panel1.Controls.Add(btnDeletStaffAdmin);
            panel1.Controls.Add(btnEditStaffAdmin);
            panel1.Controls.Add(btnSearchStaff);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 437);
            panel1.TabIndex = 0;
            // 
            // btnDeletStaffAdmin
            // 
            btnDeletStaffAdmin.BackColor = Color.FromArgb(255, 128, 128);
            btnDeletStaffAdmin.Image = Properties.Resources.bin;
            btnDeletStaffAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletStaffAdmin.Location = new Point(763, 393);
            btnDeletStaffAdmin.Name = "btnDeletStaffAdmin";
            btnDeletStaffAdmin.Size = new Size(64, 32);
            btnDeletStaffAdmin.TabIndex = 13;
            btnDeletStaffAdmin.Text = "Delete";
            btnDeletStaffAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnDeletStaffAdmin.UseVisualStyleBackColor = false;
            btnDeletStaffAdmin.Click += btnDeletStaffAdmin_Click;
            // 
            // btnEditStaffAdmin
            // 
            btnEditStaffAdmin.BackColor = Color.MediumTurquoise;
            btnEditStaffAdmin.Image = Properties.Resources.edit;
            btnEditStaffAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditStaffAdmin.Location = new Point(763, 136);
            btnEditStaffAdmin.Name = "btnEditStaffAdmin";
            btnEditStaffAdmin.Size = new Size(64, 32);
            btnEditStaffAdmin.TabIndex = 12;
            btnEditStaffAdmin.Text = "Edit";
            btnEditStaffAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnEditStaffAdmin.UseVisualStyleBackColor = false;
            btnEditStaffAdmin.Click += btnEditStaffAdmin_Click;
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.BackColor = Color.FromArgb(255, 224, 192);
            btnSearchStaff.Image = Properties.Resources.loupe;
            btnSearchStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchStaff.Location = new Point(464, 67);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(69, 27);
            btnSearchStaff.TabIndex = 8;
            btnSearchStaff.Text = "Search";
            btnSearchStaff.TextAlign = ContentAlignment.MiddleRight;
            btnSearchStaff.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 25);
            textBox1.TabIndex = 7;
            textBox1.Text = "Search Staff";
            // 
            // btnNewStaffAdmin
            // 
            btnNewStaffAdmin.BackColor = Color.FromArgb(255, 224, 192);
            btnNewStaffAdmin.Image = Properties.Resources.add_user;
            btnNewStaffAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewStaffAdmin.Location = new Point(763, 98);
            btnNewStaffAdmin.Name = "btnNewStaffAdmin";
            btnNewStaffAdmin.Size = new Size(64, 32);
            btnNewStaffAdmin.TabIndex = 11;
            btnNewStaffAdmin.Text = "Add";
            btnNewStaffAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnNewStaffAdmin.UseVisualStyleBackColor = false;
            btnNewStaffAdmin.Click += btnNewStaffAdmin_Click;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new Point(12, 98);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStaff.Size = new Size(745, 328);
            dataGridViewStaff.TabIndex = 10;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // StaffAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 437);
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
    }
}