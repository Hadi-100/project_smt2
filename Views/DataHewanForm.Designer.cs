namespace project_smt2.Views
{
    partial class DataHewanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataHewanForm));
            dataGridViewDataHewan = new DataGridView();
            lblhewantersedia = new Label();
            lbltotalsapi = new Label();
            lbltotalkambing = new Label();
            lblhewanterjual = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataHewan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDataHewan
            // 
            dataGridViewDataHewan.Anchor = AnchorStyles.None;
            dataGridViewDataHewan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDataHewan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDataHewan.BorderStyle = BorderStyle.None;
            dataGridViewDataHewan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataHewan.Location = new Point(106, 409);
            dataGridViewDataHewan.Margin = new Padding(2);
            dataGridViewDataHewan.Name = "dataGridViewDataHewan";
            dataGridViewDataHewan.RowHeadersWidth = 82;
            dataGridViewDataHewan.Size = new Size(1346, 530);
            dataGridViewDataHewan.TabIndex = 0;
            dataGridViewDataHewan.CellContentClick += dataGridViewDataHewan_CellContentClick;
            // 
            // lblhewantersedia
            // 
            lblhewantersedia.AutoSize = true;
            lblhewantersedia.BackColor = Color.Transparent;
            lblhewantersedia.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhewantersedia.Location = new Point(177, 290);
            lblhewantersedia.Margin = new Padding(2, 0, 2, 0);
            lblhewantersedia.Name = "lblhewantersedia";
            lblhewantersedia.Size = new Size(41, 30);
            lblhewantersedia.TabIndex = 1;
            lblhewantersedia.Text = "10";
            lblhewantersedia.Click += label1_Click;
            // 
            // lbltotalsapi
            // 
            lbltotalsapi.AutoSize = true;
            lbltotalsapi.BackColor = Color.Transparent;
            lbltotalsapi.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalsapi.Location = new Point(464, 289);
            lbltotalsapi.Margin = new Padding(2, 0, 2, 0);
            lbltotalsapi.Name = "lbltotalsapi";
            lbltotalsapi.Size = new Size(41, 30);
            lbltotalsapi.TabIndex = 2;
            lbltotalsapi.Text = "10";
            lbltotalsapi.Click += lbltotalsapi_Click;
            // 
            // lbltotalkambing
            // 
            lbltotalkambing.AutoSize = true;
            lbltotalkambing.BackColor = Color.Transparent;
            lbltotalkambing.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalkambing.Location = new Point(758, 289);
            lbltotalkambing.Margin = new Padding(2, 0, 2, 0);
            lbltotalkambing.Name = "lbltotalkambing";
            lbltotalkambing.Size = new Size(41, 30);
            lbltotalkambing.TabIndex = 3;
            lbltotalkambing.Text = "10";
            lbltotalkambing.Click += label1_Click_1;
            // 
            // lblhewanterjual
            // 
            lblhewanterjual.AutoSize = true;
            lblhewanterjual.BackColor = Color.Transparent;
            lblhewanterjual.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhewanterjual.Location = new Point(1045, 289);
            lblhewanterjual.Margin = new Padding(2, 0, 2, 0);
            lblhewanterjual.Name = "lblhewanterjual";
            lblhewanterjual.Size = new Size(41, 30);
            lblhewanterjual.TabIndex = 4;
            lblhewanterjual.Text = "10";
            lblhewanterjual.Click += lblhewanterjual_Click;
            // 
            // DataHewanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblhewanterjual);
            Controls.Add(lbltotalkambing);
            Controls.Add(lbltotalsapi);
            Controls.Add(lblhewantersedia);
            Controls.Add(dataGridViewDataHewan);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "DataHewanForm";
            Size = new Size(1600, 1020);
            Load += DataHewanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataHewan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDataHewan;
        private Label lblhewantersedia;
        private Label lbltotalsapi;
        private Label lbltotalkambing;
        private Label lblhewanterjual;
    }
}
