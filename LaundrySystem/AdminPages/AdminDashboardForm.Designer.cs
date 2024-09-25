namespace LaundrySystem.AdminPages
{
    partial class AdminDashboardForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel12 = new Panel();
            labelStaff = new Label();
            labelCustomer = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            labelRevenue = new Label();
            btnSearchStaff = new Button();
            textBox1 = new TextBox();
            buttonDashboardTotalStaff = new Button();
            buttonDashboardTotalCustomer = new Button();
            buttonDashboardTotalCompletedOrders = new Button();
            label2 = new Label();
            buttonDashboardTotalPendings = new Button();
            buttonDashboardTotalOrders = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel12.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel12);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 437);
            panel1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(labelStaff);
            panel12.Controls.Add(labelCustomer);
            panel12.Controls.Add(label4);
            panel12.Controls.Add(label3);
            panel12.Controls.Add(panel2);
            panel12.Controls.Add(btnSearchStaff);
            panel12.Controls.Add(textBox1);
            panel12.Controls.Add(buttonDashboardTotalStaff);
            panel12.Controls.Add(buttonDashboardTotalCustomer);
            panel12.Controls.Add(buttonDashboardTotalCompletedOrders);
            panel12.Controls.Add(label2);
            panel12.Controls.Add(buttonDashboardTotalPendings);
            panel12.Controls.Add(buttonDashboardTotalOrders);
            panel12.Controls.Add(label1);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(838, 437);
            panel12.TabIndex = 1;
            // 
            // labelStaff
            // 
            labelStaff.AutoSize = true;
            labelStaff.BackColor = Color.FromArgb(255, 192, 128);
            labelStaff.Font = new Font("Castellar", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStaff.Location = new Point(765, 148);
            labelStaff.Name = "labelStaff";
            labelStaff.Size = new Size(41, 39);
            labelStaff.TabIndex = 17;
            labelStaff.Text = "0";
            labelStaff.Click += labelStaff_Click;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.BackColor = Color.FromArgb(255, 192, 128);
            labelCustomer.Font = new Font("Castellar", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCustomer.Location = new Point(550, 149);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(41, 39);
            labelCustomer.TabIndex = 16;
            labelCustomer.Text = "0";
            labelCustomer.Click += labelCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 128);
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.Location = new Point(186, 358);
            label4.Name = "label4";
            label4.Size = new Size(27, 32);
            label4.TabIndex = 15;
            label4.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 128);
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(186, 255);
            label3.Name = "label3";
            label3.Size = new Size(27, 32);
            label3.TabIndex = 14;
            label3.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelRevenue);
            panel2.Location = new Point(262, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 201);
            panel2.TabIndex = 13;
            // 
            // labelRevenue
            // 
            labelRevenue.AutoSize = true;
            labelRevenue.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRevenue.Location = new Point(11, 10);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(68, 20);
            labelRevenue.TabIndex = 0;
            labelRevenue.Text = "Revenue";
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.BackColor = Color.FromArgb(192, 255, 192);
            btnSearchStaff.Image = Properties.Resources.loupe;
            btnSearchStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchStaff.Location = new Point(737, 32);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(69, 27);
            btnSearchStaff.TabIndex = 12;
            btnSearchStaff.Text = "Search";
            btnSearchStaff.TextAlign = ContentAlignment.MiddleRight;
            btnSearchStaff.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(285, 32);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search anything here...";
            textBox1.Size = new Size(446, 25);
            textBox1.TabIndex = 11;
            // 
            // buttonDashboardTotalStaff
            // 
            buttonDashboardTotalStaff.BackColor = Color.FromArgb(255, 192, 128);
            buttonDashboardTotalStaff.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboardTotalStaff.Image = Properties.Resources.laundry__2_;
            buttonDashboardTotalStaff.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboardTotalStaff.Location = new Point(609, 118);
            buttonDashboardTotalStaff.Name = "buttonDashboardTotalStaff";
            buttonDashboardTotalStaff.Size = new Size(217, 101);
            buttonDashboardTotalStaff.TabIndex = 8;
            buttonDashboardTotalStaff.Text = "Staff";
            buttonDashboardTotalStaff.UseVisualStyleBackColor = false;
            buttonDashboardTotalStaff.Click += buttonDashboardTotalStaff_Click;
            // 
            // buttonDashboardTotalCustomer
            // 
            buttonDashboardTotalCustomer.BackColor = Color.FromArgb(255, 192, 128);
            buttonDashboardTotalCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboardTotalCustomer.Image = Properties.Resources.clothes_hanger__1_;
            buttonDashboardTotalCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboardTotalCustomer.Location = new Point(386, 118);
            buttonDashboardTotalCustomer.Name = "buttonDashboardTotalCustomer";
            buttonDashboardTotalCustomer.Size = new Size(217, 101);
            buttonDashboardTotalCustomer.TabIndex = 7;
            buttonDashboardTotalCustomer.Text = "Customer";
            buttonDashboardTotalCustomer.UseVisualStyleBackColor = false;
            buttonDashboardTotalCustomer.Click += buttonDashboardTotalCustomer_Click;
            // 
            // buttonDashboardTotalCompletedOrders
            // 
            buttonDashboardTotalCompletedOrders.BackColor = Color.FromArgb(255, 192, 128);
            buttonDashboardTotalCompletedOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboardTotalCompletedOrders.Location = new Point(24, 224);
            buttonDashboardTotalCompletedOrders.Name = "buttonDashboardTotalCompletedOrders";
            buttonDashboardTotalCompletedOrders.Size = new Size(203, 100);
            buttonDashboardTotalCompletedOrders.TabIndex = 5;
            buttonDashboardTotalCompletedOrders.Text = "Completed Orders";
            buttonDashboardTotalCompletedOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboardTotalCompletedOrders.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.Location = new Point(186, 147);
            label2.Name = "label2";
            label2.Size = new Size(27, 32);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // buttonDashboardTotalPendings
            // 
            buttonDashboardTotalPendings.BackColor = Color.FromArgb(255, 192, 128);
            buttonDashboardTotalPendings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboardTotalPendings.Location = new Point(24, 115);
            buttonDashboardTotalPendings.Name = "buttonDashboardTotalPendings";
            buttonDashboardTotalPendings.Size = new Size(203, 103);
            buttonDashboardTotalPendings.TabIndex = 3;
            buttonDashboardTotalPendings.Text = "Pending Orders";
            buttonDashboardTotalPendings.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboardTotalPendings.UseVisualStyleBackColor = false;
            // 
            // buttonDashboardTotalOrders
            // 
            buttonDashboardTotalOrders.BackColor = Color.FromArgb(255, 192, 128);
            buttonDashboardTotalOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboardTotalOrders.Location = new Point(24, 328);
            buttonDashboardTotalOrders.Name = "buttonDashboardTotalOrders";
            buttonDashboardTotalOrders.Size = new Size(203, 94);
            buttonDashboardTotalOrders.TabIndex = 1;
            buttonDashboardTotalOrders.Text = "Total Orders";
            buttonDashboardTotalOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboardTotalOrders.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 437);
            Controls.Add(panel1);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            panel1.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel12;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource bindingSource1;
        private Button buttonDashboardTotalOrders;
        private Button buttonDashboardTotalCompletedOrders;
        private Label label2;
        private Button buttonDashboardTotalPendings;
        private Button buttonDashboardTotalStaff;
        private Button buttonDashboardTotalCustomer;
        private TextBox textBox1;
        private Panel panel2;
        private Button btnSearchStaff;
        private Label labelRevenue;
        private Label labelStaff;
        private Label labelCustomer;
        private Label label4;
        private Label label3;
    }
}