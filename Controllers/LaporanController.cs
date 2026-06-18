using Npgsql;
using project_smt2.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace project_smt2.Controllers
{
    internal class LaporanController
    {
        public string GetPeternak()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT nama_peternak FROM peternak WHERE status_hewan = 'Tersedia'", conn);
                return Convert.ToString(cmd.ExecuteScalar());
            }
        }

        public DataTable GetPenjualanPeternak()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT nama_peternak, total_penjualan FROM view_total_penjualan_peternakan";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable GetPerformaPeternak()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT * FROM view_performa_penjualan_peternak";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetKeuntunganPerBulan()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT
                        bulan AS bulan_label, keuntungan_bersih AS bersih, keuntungan_kotor AS kotor
                    FROM view_total_pendapatan
                    GROUP BY bulan, keuntungan_bersih, keuntungan_kotor
                    ORDER BY bulan";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public decimal GetPendapatan()
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT COALESCE(
                    SUM(harga_jual),0)
                  FROM detail_transaksi";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public int GetTotalTransaksi()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(transaksi_id) FROM transaksi", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalHewanDitangani()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    @"SELECT COUNT(hewan_ternak_id) FROM hewan_ternak", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public decimal GetRataPenjualan()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    @"SELECT rata_rata_per_transaksi FROM view_rata_penjualan", conn);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}