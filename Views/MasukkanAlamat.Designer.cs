namespace project_smt2.Views
{
    partial class MasukkanAlamat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasukkanAlamat));
            tbAlamatLengkap = new TextBox();
            cbKecamatan = new ComboBox();
            cbDesa = new ComboBox();
            btnSelanjutnya = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // tbAlamatLengkap
            // 
            tbAlamatLengkap.BorderStyle = BorderStyle.None;
            tbAlamatLengkap.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlamatLengkap.Location = new Point(291, 306);
            tbAlamatLengkap.Margin = new Padding(2);
            tbAlamatLengkap.Name = "tbAlamatLengkap";
            tbAlamatLengkap.Size = new Size(684, 20);
            tbAlamatLengkap.TabIndex = 0;
            tbAlamatLengkap.TextChanged += tbAlamatLengkap_TextChanged;
            // 
            // cbKecamatan
            // 
            cbKecamatan.BackColor = Color.White;
            cbKecamatan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKecamatan.FlatStyle = FlatStyle.Popup;
            cbKecamatan.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKecamatan.FormattingEnabled = true;
            cbKecamatan.Location = new Point(291, 438);
            cbKecamatan.Margin = new Padding(2);
            cbKecamatan.Name = "cbKecamatan";
            cbKecamatan.Size = new Size(235, 25);
            cbKecamatan.TabIndex = 1;
            cbKecamatan.SelectedIndexChanged += cbKecamatan_SelectedIndexChanged;
            // 
            // cbDesa
            // 
            cbDesa.BackColor = Color.White;
            cbDesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDesa.Enabled = false;
            cbDesa.FlatStyle = FlatStyle.Popup;
            cbDesa.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDesa.FormattingEnabled = true;
            cbDesa.Location = new Point(632, 438);
            cbDesa.Margin = new Padding(2);
            cbDesa.Name = "cbDesa";
            cbDesa.Size = new Size(225, 25);
            cbDesa.TabIndex = 2;
            cbDesa.SelectedIndexChanged += cbDesa_SelectedIndexChanged;
            // 
            // btnSelanjutnya
            // 
            btnSelanjutnya.BackColor = Color.Transparent;
            btnSelanjutnya.BackgroundImageLayout = ImageLayout.Stretch;
            btnSelanjutnya.FlatStyle = FlatStyle.Popup;
            btnSelanjutnya.Font = new Font("Segoe UI", 1F);
            btnSelanjutnya.ForeColor = Color.White;
            btnSelanjutnya.Location = new Point(1190, 675);
            btnSelanjutnya.Margin = new Padding(2);
            btnSelanjutnya.Name = "btnSelanjutnya";
            btnSelanjutnya.Size = new Size(115, 63);
            btnSelanjutnya.TabIndex = 3;
            btnSelanjutnya.Text = ".";
            btnSelanjutnya.UseVisualStyleBackColor = false;
            btnSelanjutnya.Click += btnSelanjutnya_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnKembali.FlatStyle = FlatStyle.Popup;
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(1032, 675);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(110, 62);
            btnKembali.TabIndex = 4;
            btnKembali.Text = ".";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // MasukkanAlamat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnKembali);
            Controls.Add(btnSelanjutnya);
            Controls.Add(cbDesa);
            Controls.Add(cbKecamatan);
            Controls.Add(tbAlamatLengkap);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "MasukkanAlamat";
            Size = new Size(1538, 832);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAlamatLengkap;
        private ComboBox cbKecamatan;
        private ComboBox cbDesa;
        private Button btnSelanjutnya;
        private Button btnKembali;
    }
}
