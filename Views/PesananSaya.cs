using System;
using System.Windows.Forms;
using System.Data;
using Npgsql;
using project_smt2.Helpers;
using project_smt2.Controllers;

namespace project_smt2.Views
{
    public partial class PesananSaya : UserControl
    {
        public PesananSaya()
        {
            InitializeComponent();
        }

        private void LoadPesananSaya(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT
                    t.transaksi_id AS ""ID Transaksi"",
                    t.tanggal_transaksi AS ""Tanggal"",
                    h.hewan_ternak_id AS ""ID Hewan"",
                    dt.harga_jual AS ""Harga Jual"",
                    t.status_pembayaran AS ""Pembayaran"",
                    dp.status_pengiriman AS ""Pengiriman""
                FROM transaksi t
                JOIN detail_transaksi dt
                    ON t.transaksi_id = dt.transaksi_id
                JOIN hewan_ternak h
                    ON dt.hewan_ternak_id = h.hewan_ternak_id
                LEFT JOIN data_pengiriman dp
                    ON t.transaksi_id = dp.transaksi_id
                ORDER BY t.transaksi_id DESC";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                DataTable dtb = new DataTable();

                da.Fill(dtb);

                dgvPesananSaya.DataSource = dtb;

                //Total pesanan
                lblTotalPesanan.Text = dtb.Rows.Count.ToString();

                //Proses pengiriman
                int proses = 0;

                //Sudah selesai
                int selesai = 0;

                foreach (DataRow row in dtb.Rows)
                {
                    string statusPengiriman = row["Pengiriman"].ToString();
                    if (statusPengiriman == "Proses")
                    {
                        proses++;
                    }
                    else if (statusPengiriman == "Selesai")
                    {
                        selesai++;
                    }
                }

                lblProsesPengiriman.Text = proses.ToString();
                lblSudahSelesai.Text = selesai.ToString();

            }
        }
    }
}  