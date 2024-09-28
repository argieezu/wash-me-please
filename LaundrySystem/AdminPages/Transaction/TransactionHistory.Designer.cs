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
            buttonEditTransaction = new Button();
            buttonDeleteTransaction = new Button();
            dataGridViewTransactionHistory = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonEditTransaction);
            panel1.Controls.Add(buttonDeleteTransaction);
            panel1.Controls.Add(dataGridViewTransactionHistory);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 440);
            panel1.TabIndex = 0;
            // 
            // buttonEditTransaction
            // 
            buttonEditTransaction.BackColor = Color.FromArgb(128, 255, 255);
            buttonEditTransaction.FlatAppearance.BorderSize = 0;
            buttonEditTransaction.FlatStyle = FlatStyle.Flat;
            buttonEditTransaction.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditTransaction.Location = new Point(765, 90);
            buttonEditTransaction.Name = "buttonEditTransaction";
            buttonEditTransaction.Size = new Size(150, 34);
            buttonEditTransaction.TabIndex = 25;
            buttonEditTransaction.Text = "Edit";
            buttonEditTransaction.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteTransaction
            // 
            buttonDeleteTransaction.BackColor = Color.FromArgb(255, 128, 128);
            buttonDeleteTransaction.FlatAppearance.BorderSize = 0;
            buttonDeleteTransaction.FlatStyle = FlatStyle.Flat;
            buttonDeleteTransaction.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteTransaction.Location = new Point(765, 386);
            buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            buttonDeleteTransaction.Size = new Size(150, 34);
            buttonDeleteTransaction.TabIndex = 24;
            buttonDeleteTransaction.Text = "Delete";
            buttonDeleteTransaction.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTransactionHistory
            // 
            dataGridViewTransactionHistory.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactionHistory.Location = new Point(28, 90);
            dataGridViewTransactionHistory.Name = "dataGridViewTransactionHistory";
            dataGridViewTransactionHistory.Size = new Size(717, 330);
            dataGridViewTransactionHistory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(181, 40);
            label1.TabIndex = 0;
            label1.Text = "Transactions";
            // 
            // TransactionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 440);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button buttonEditTransaction;
        private Button buttonDeleteTransaction;
    }
}