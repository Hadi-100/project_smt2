using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace project_smt2.Views
{
    public partial class DashboardAdminForm : Form
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

        private Button btnLogout;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdminForm));
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(22, 851);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 41);
            btnLogout.TabIndex = 0;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button1_Click_1;
            // 
            // DashboardAdminForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1817, 987);
            Controls.Add(btnLogout);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += DashboardAdminForm_Load_1;
            ResumeLayout(false);
        }
    }
    #endregion
}