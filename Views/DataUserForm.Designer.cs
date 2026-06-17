namespace project_smt2.Views
{
    partial class DataUserForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataUserForm));
            dataGridView1 = new DataGridView();
            lblTotalUser = new Label();
            lblTotalAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(119, 393);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1823, 1001);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblTotalUser
            // 
            lblTotalUser.AutoSize = true;
            lblTotalUser.BackColor = Color.Transparent;
            lblTotalUser.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUser.Location = new Point(2129, 506);
            lblTotalUser.Margin = new Padding(5, 0, 5, 0);
            lblTotalUser.Name = "lblTotalUser";
            lblTotalUser.Size = new Size(160, 56);
            lblTotalUser.TabIndex = 1;
            lblTotalUser.Text = "label1";
            lblTotalUser.Click += lblTotalUser_Click;
            // 
            // lblTotalAdmin
            // 
            lblTotalAdmin.AutoSize = true;
            lblTotalAdmin.BackColor = Color.Transparent;
            lblTotalAdmin.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAdmin.Location = new Point(2129, 902);
            lblTotalAdmin.Margin = new Padding(5, 0, 5, 0);
            lblTotalAdmin.Name = "lblTotalAdmin";
            lblTotalAdmin.Size = new Size(160, 56);
            lblTotalAdmin.TabIndex = 2;
            lblTotalAdmin.Text = "label2";
            lblTotalAdmin.Click += lblTotalAdmin_Click;
            // 
            // DataUserForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            //BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblTotalAdmin);
            Controls.Add(lblTotalUser);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "DataUserForm";
            Size = new Size(2600, 1632);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTotalUser;
        private Label lblTotalAdmin;
    }
}
