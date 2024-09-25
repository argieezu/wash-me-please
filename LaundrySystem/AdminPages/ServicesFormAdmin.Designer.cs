namespace LaundrySystem.AdminPages
{
    partial class ServicesFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesFormAdmin));
            panel1 = new Panel();
            button1 = new Button();
            dataGridViewServiceManagement = new DataGridView();
            buttonAddServices = new Button();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            textBoxDescription = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBoxServiceType = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            textBoxPrice = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServiceManagement).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridViewServiceManagement);
            panel1.Controls.Add(buttonAddServices);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 398);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.edit;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(422, 351);
            button1.Name = "button1";
            button1.Size = new Size(95, 35);
            button1.TabIndex = 8;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewServiceManagement
            // 
            dataGridViewServiceManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServiceManagement.Location = new Point(321, 107);
            dataGridViewServiceManagement.Name = "dataGridViewServiceManagement";
            dataGridViewServiceManagement.Size = new Size(519, 229);
            dataGridViewServiceManagement.TabIndex = 7;
            // 
            // buttonAddServices
            // 
            buttonAddServices.BackColor = Color.PaleGreen;
            buttonAddServices.FlatAppearance.BorderSize = 0;
            buttonAddServices.FlatStyle = FlatStyle.Flat;
            buttonAddServices.Image = Properties.Resources.add;
            buttonAddServices.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddServices.Location = new Point(321, 351);
            buttonAddServices.Name = "buttonAddServices";
            buttonAddServices.Size = new Size(95, 35);
            buttonAddServices.TabIndex = 6;
            buttonAddServices.Text = "Add";
            buttonAddServices.UseVisualStyleBackColor = false;
            buttonAddServices.Click += buttonAddServices_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBoxDescription);
            panel4.Location = new Point(25, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 90);
            panel4.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.job_description;
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(71, 77);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 14);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 2;
            label4.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescription.Location = new Point(83, 42);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "description";
            textBoxDescription.Size = new Size(175, 29);
            textBoxDescription.TabIndex = 1;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxServiceType);
            panel2.Location = new Point(25, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 74);
            panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 67);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tag;
            pictureBox1.Location = new Point(8, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 3);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 2;
            label2.Text = "Service Type";
            // 
            // textBoxServiceType
            // 
            textBoxServiceType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxServiceType.Location = new Point(81, 31);
            textBoxServiceType.Name = "textBoxServiceType";
            textBoxServiceType.PlaceholderText = "Service type";
            textBoxServiceType.Size = new Size(177, 29);
            textBoxServiceType.TabIndex = 1;
            textBoxServiceType.TextChanged += textBoxServiceType_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(284, 40);
            label1.TabIndex = 0;
            label1.Text = "Service Management";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBoxPrice);
            panel3.Location = new Point(25, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 81);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 69);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 10);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrice.Location = new Point(83, 38);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "0";
            textBoxPrice.Size = new Size(175, 29);
            textBoxPrice.TabIndex = 1;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.bin;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(745, 351);
            button2.Name = "button2";
            button2.Size = new Size(95, 35);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // ServicesFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 398);
            Controls.Add(panel1);
            Name = "ServicesFormAdmin";
            Text = "ServicesFormAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServiceManagement).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox textBoxServiceType;
        private Panel panel4;
        private Label label4;
        private TextBox textBoxDescription;
        private Panel panel3;
        private Label label3;
        private TextBox textBoxPrice;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonAddServices;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DataGridView dataGridViewServiceManagement;
        private Button button1;
        private Button button2;
    }
}