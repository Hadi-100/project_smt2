namespace project_smt2.Views
{
    partial class PembayaranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PembayaranForm));
            cmbBank = new ComboBox();
            tbNoRekening = new TextBox();
            tbNominal = new TextBox();
            btnBatal = new Button();
            btnBayar = new Button();
            SuspendLayout();
            // 
            // cmbBank
            // 
            cmbBank.FormattingEnabled = true;
            cmbBank.Location = new Point(523, 236);
            cmbBank.Margin = new Padding(2);
            cmbBank.Name = "cmbBank";
            cmbBank.Size = new Size(210, 28);
            cmbBank.TabIndex = 0;
            cmbBank.SelectedIndexChanged += cmbBank_SelectedIndexChanged;
            // 
            // tbNoRekening
            // 
            tbNoRekening.Location = new Point(523, 394);
            tbNoRekening.Margin = new Padding(2);
            tbNoRekening.Name = "tbNoRekening";
            tbNoRekening.Size = new Size(498, 27);
            tbNoRekening.TabIndex = 1;
            tbNoRekening.TextChanged += tbNoRekening_TextChanged;
            // 
            // tbNominal
            // 
            tbNominal.Location = new Point(523, 551);
            tbNominal.Margin = new Padding(2);
            tbNominal.Name = "tbNominal";
            tbNominal.Size = new Size(314, 27);
            tbNominal.TabIndex = 2;
            tbNominal.TextChanged += tbNominal_TextChanged;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.BackgroundImageLayout = ImageLayout.Stretch;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Segoe UI", 1.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonFace;
            btnBatal.Location = new Point(794, 741);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 63);
            btnBatal.TabIndex = 3;
            btnBatal.Text = ".";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.Transparent;
            btnBayar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBayar.FlatStyle = FlatStyle.Popup;
            btnBayar.Font = new Font("Segoe UI", 1.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = SystemColors.ButtonFace;
            btnBayar.Location = new Point(936, 741);
            btnBayar.Margin = new Padding(2);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(112, 63);
            btnBayar.TabIndex = 4;
            btnBayar.Text = ".";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // PembayaranForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnBayar);
            Controls.Add(btnBatal);
            Controls.Add(tbNominal);
            Controls.Add(tbNoRekening);
            Controls.Add(cmbBank);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "PembayaranForm";
            Size = new Size(1538, 832);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBank;
        private TextBox tbNoRekening;
        private TextBox tbNominal;
        private Button btnBatal;
        private Button btnBayar;
    }
}
