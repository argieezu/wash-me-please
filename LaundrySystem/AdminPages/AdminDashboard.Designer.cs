﻿namespace LaundrySystem.AdminPages
{
    partial class AdminDashboard
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
            panel2 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 538);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(178, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 89);
            panel2.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
    }
}