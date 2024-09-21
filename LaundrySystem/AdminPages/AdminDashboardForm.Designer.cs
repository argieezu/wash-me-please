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
            panel2 = new Panel();
            label6 = new Label();
            btnSearchStaff = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            buttonTotalOrderDisplay = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
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
            panel12.Controls.Add(label7);
            panel12.Controls.Add(label5);
            panel12.Controls.Add(label4);
            panel12.Controls.Add(label3);
            panel12.Controls.Add(panel2);
            panel12.Controls.Add(btnSearchStaff);
            panel12.Controls.Add(textBox1);
            panel12.Controls.Add(button4);
            panel12.Controls.Add(button3);
            panel12.Controls.Add(button2);
            panel12.Controls.Add(label2);
            panel12.Controls.Add(button1);
            panel12.Controls.Add(buttonTotalOrderDisplay);
            panel12.Controls.Add(label1);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(838, 437);
            panel12.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(262, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 201);
            panel2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 10);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 0;
            label6.Text = "Revenue";
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.BackColor = Color.FromArgb(255, 224, 192);
            btnSearchStaff.Image = Properties.Resources.loupe;
            btnSearchStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchStaff.Location = new Point(737, 30);
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
            textBox1.Size = new Size(446, 25);
            textBox1.TabIndex = 11;
            textBox1.Text = "Search anything here...";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(603, 115);
            button4.Name = "button4";
            button4.Size = new Size(203, 71);
            button4.TabIndex = 8;
            button4.Text = "Staff";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(394, 115);
            button3.Name = "button3";
            button3.Size = new Size(203, 71);
            button3.TabIndex = 7;
            button3.Text = "Customer";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(24, 224);
            button2.Name = "button2";
            button2.Size = new Size(203, 88);
            button2.TabIndex = 5;
            button2.Text = "Completed Orders";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.Location = new Point(186, 141);
            label2.Name = "label2";
            label2.Size = new Size(27, 32);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 115);
            button1.Name = "button1";
            button1.Size = new Size(203, 91);
            button1.TabIndex = 3;
            button1.Text = "Pending Orders";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonTotalOrderDisplay
            // 
            buttonTotalOrderDisplay.BackColor = Color.FromArgb(255, 224, 192);
            buttonTotalOrderDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTotalOrderDisplay.Location = new Point(24, 333);
            buttonTotalOrderDisplay.Name = "buttonTotalOrderDisplay";
            buttonTotalOrderDisplay.Size = new Size(203, 89);
            buttonTotalOrderDisplay.TabIndex = 1;
            buttonTotalOrderDisplay.Text = "Total Orders";
            buttonTotalOrderDisplay.TextAlign = ContentAlignment.MiddleLeft;
            buttonTotalOrderDisplay.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 224, 192);
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(186, 249);
            label3.Name = "label3";
            label3.Size = new Size(27, 32);
            label3.TabIndex = 14;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 224, 192);
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.Location = new Point(186, 358);
            label4.Name = "label4";
            label4.Size = new Size(27, 32);
            label4.TabIndex = 15;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 224, 192);
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label5.Location = new Point(534, 133);
            label5.Name = "label5";
            label5.Size = new Size(27, 32);
            label5.TabIndex = 16;
            label5.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label7.Location = new Point(748, 134);
            label7.Name = "label7";
            label7.Size = new Size(27, 32);
            label7.TabIndex = 17;
            label7.Text = "0";
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
        private Button buttonTotalOrderDisplay;
        private Button button2;
        private Label label2;
        private Button button1;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
        private Panel panel2;
        private Button btnSearchStaff;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}