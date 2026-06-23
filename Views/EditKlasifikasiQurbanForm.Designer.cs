namespace project_smt2
{
    partial class EditKlasifikasiQurbanForm
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
            label1 = new Label();
            cbxJenisHewan = new ComboBox();
            cbxKondisiHewan = new ComboBox();
            cbxPeternak = new ComboBox();
            tbHarga = new TextBox();
            tbBerat = new TextBox();
            tbUmur = new TextBox();
            cbxJenisKelamin = new ComboBox();
            btnKonfirmasi = new Button();
            btnBatal = new Button();
            dtpTglCek = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(111, 17);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 0;
            label1.Text = "Edit Atribut Hewan";
            // 
            // cbxJenisHewan
            // 
            cbxJenisHewan.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxJenisHewan.ForeColor = Color.DarkGray;
            cbxJenisHewan.FormattingEnabled = true;
            cbxJenisHewan.Items.AddRange(new object[] { "1 Sapi ", "2 Kambing", "3 Sapi Limousin", "4 Sapi Brahmana", "5 Kambing Kacang", "6 Kambing Etawa", "7 Kambing JawaRandu" });
            cbxJenisHewan.Location = new Point(57, 142);
            cbxJenisHewan.Name = "cbxJenisHewan";
            cbxJenisHewan.Size = new Size(350, 40);
            cbxJenisHewan.TabIndex = 4;
            cbxJenisHewan.Text = "Jenis Hewan";
            // 
            // cbxKondisiHewan
            // 
            cbxKondisiHewan.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxKondisiHewan.ForeColor = Color.DarkGray;
            cbxKondisiHewan.FormattingEnabled = true;
            cbxKondisiHewan.Items.AddRange(new object[] { "Sehat", "Sakit", "Cacat Ringan", "Cacat Berat" });
            cbxKondisiHewan.Location = new Point(57, 589);
            cbxKondisiHewan.Name = "cbxKondisiHewan";
            cbxKondisiHewan.Size = new Size(350, 40);
            cbxKondisiHewan.TabIndex = 7;
            cbxKondisiHewan.Text = "Kondisi hewan";
            // 
            // cbxPeternak
            // 
            cbxPeternak.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPeternak.ForeColor = Color.DarkGray;
            cbxPeternak.FormattingEnabled = true;
            cbxPeternak.Items.AddRange(new object[] { "1 (Pak Ali)", "2 (Bu Rina) ", "3 (Pak Budi)", "3 (Bu Sari)", "4 (Pak Joko)", "5 (Bu Maya) ", "6 (Pak Tono)" });
            cbxPeternak.Location = new Point(57, 217);
            cbxPeternak.Name = "cbxPeternak";
            cbxPeternak.Size = new Size(350, 40);
            cbxPeternak.TabIndex = 8;
            cbxPeternak.Text = "Nama Peternak";
            // 
            // tbHarga
            // 
            tbHarga.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHarga.ForeColor = Color.DarkGray;
            tbHarga.Location = new Point(57, 515);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(299, 39);
            tbHarga.TabIndex = 3;
            tbHarga.Text = "Harga";
            // 
            // tbBerat
            // 
            tbBerat.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBerat.ForeColor = Color.DarkGray;
            tbBerat.Location = new Point(57, 441);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(128, 39);
            tbBerat.TabIndex = 9;
            tbBerat.Text = "Berat";
            // 
            // tbUmur
            // 
            tbUmur.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUmur.ForeColor = Color.DarkGray;
            tbUmur.Location = new Point(57, 367);
            tbUmur.Name = "tbUmur";
            tbUmur.Size = new Size(128, 39);
            tbUmur.TabIndex = 10;
            tbUmur.Text = "Umur";
            // 
            // cbxJenisKelamin
            // 
            cbxJenisKelamin.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxJenisKelamin.ForeColor = Color.DarkGray;
            cbxJenisKelamin.FormattingEnabled = true;
            cbxJenisKelamin.Items.AddRange(new object[] { "Jantan", "Betina" });
            cbxJenisKelamin.Location = new Point(57, 292);
            cbxJenisKelamin.Name = "cbxJenisKelamin";
            cbxJenisKelamin.Size = new Size(350, 40);
            cbxJenisKelamin.TabIndex = 11;
            cbxJenisKelamin.Text = "Jenis Kelamin";
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.MediumSeaGreen;
            btnKonfirmasi.BackgroundImageLayout = ImageLayout.Center;
            btnKonfirmasi.FlatStyle = FlatStyle.Popup;
            btnKonfirmasi.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.ForeColor = Color.WhiteSmoke;
            btnKonfirmasi.Location = new Point(424, 782);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(153, 40);
            btnKonfirmasi.TabIndex = 12;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += button1_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.BackgroundImageLayout = ImageLayout.Center;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.WhiteSmoke;
            btnBatal.Location = new Point(252, 782);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(139, 40);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += button2_Click;
            // 
            // dtpTglCek
            // 
            dtpTglCek.CalendarForeColor = Color.Black;
            dtpTglCek.CalendarTitleForeColor = Color.Black;
            dtpTglCek.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpTglCek.Location = new Point(57, 664);
            dtpTglCek.Name = "dtpTglCek";
            dtpTglCek.Size = new Size(501, 39);
            dtpTglCek.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(57, 632);
            label2.Name = "label2";
            label2.Size = new Size(309, 29);
            label2.TabIndex = 15;
            label2.Text = "Tanggal Terakhir CheckUp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(57, 557);
            label3.Name = "label3";
            label3.Size = new Size(184, 29);
            label3.TabIndex = 16;
            label3.Text = "Kondisi Hewan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(57, 483);
            label4.Name = "label4";
            label4.Size = new Size(80, 29);
            label4.TabIndex = 17;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(57, 409);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 18;
            label5.Text = "Berat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(57, 335);
            label6.Name = "label6";
            label6.Size = new Size(74, 29);
            label6.TabIndex = 19;
            label6.Text = "Umur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.System;
            label7.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(57, 260);
            label7.Name = "label7";
            label7.Size = new Size(172, 29);
            label7.TabIndex = 20;
            label7.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.System;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(57, 185);
            label8.Name = "label8";
            label8.Size = new Size(181, 29);
            label8.TabIndex = 21;
            label8.Text = "Nama Peternak";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.FlatStyle = FlatStyle.System;
            label9.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(57, 110);
            label9.Name = "label9";
            label9.Size = new Size(158, 29);
            label9.TabIndex = 22;
            label9.Text = "Jenis Hewan";
            // 
            // EditKlasifikasiQurbanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpTglCek);
            Controls.Add(btnBatal);
            Controls.Add(btnKonfirmasi);
            Controls.Add(cbxJenisKelamin);
            Controls.Add(tbUmur);
            Controls.Add(tbBerat);
            Controls.Add(cbxPeternak);
            Controls.Add(cbxKondisiHewan);
            Controls.Add(cbxJenisHewan);
            Controls.Add(tbHarga);
            Controls.Add(label1);
            Name = "EditKlasifikasiQurbanForm";
            Size = new Size(600, 850);
            Load += EditKlasifikasiQurbanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxJenisHewan;
        private ComboBox cbxKondisiHewan;
        private ComboBox cbxPeternak;
        private TextBox tbHarga;
        private TextBox tbBerat;
        private TextBox tbUmur;
        private ComboBox cbxJenisKelamin;
        private Button btnKonfirmasi;
        private Button btnBatal;
        private DateTimePicker dtpTglCek;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
