namespace LaundrySystem.AdminPages.Trasaction
{
    partial class TransactionHistory
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
            label1 = new Label();
            dataGridViewTransactionHistory = new DataGridView();
            buttonAddTransaction = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonAddTransaction);
            panel1.Controls.Add(dataGridViewTransactionHistory);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 440);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(272, 40);
            label1.TabIndex = 0;
            label1.Text = "Transaction History";
            // 
            // dataGridViewTransactionHistory
            // 
            dataGridViewTransactionHistory.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactionHistory.Location = new Point(28, 102);
            dataGridViewTransactionHistory.Name = "dataGridViewTransactionHistory";
            dataGridViewTransactionHistory.Size = new Size(717, 318);
            dataGridViewTransactionHistory.TabIndex = 1;
            // 
            // buttonAddTransaction
            // 
            buttonAddTransaction.BackColor = Color.FromArgb(255, 128, 128);
            buttonAddTransaction.FlatAppearance.BorderSize = 0;
            buttonAddTransaction.FlatStyle = FlatStyle.Flat;
            buttonAddTransaction.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddTransaction.Location = new Point(765, 386);
            buttonAddTransaction.Name = "buttonAddTransaction";
            buttonAddTransaction.Size = new Size(150, 34);
            buttonAddTransaction.TabIndex = 24;
            buttonAddTransaction.Text = "Delete";
            buttonAddTransaction.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(765, 335);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 25;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // TransactionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 440);
            Controls.Add(panel1);
            Name = "TransactionHistory";
            Text = "TransactionHistory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewTransactionHistory;
        private Label label1;
        private Button button1;
        private Button buttonAddTransaction;
    }
}