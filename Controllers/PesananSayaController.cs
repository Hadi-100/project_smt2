using Npgsql;
using project_smt2.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace project_smt2.Controllers
{
    public class PesananSayaController
    {
        public DataTable GetPesananSayaUser(int userId)
        {
            DataTable dt = new DataTable();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT
                    t.transaksi_id,
                    t.tanggal_transaksi,
                    h.hewan_ternak_id,
                    dt.harga_jual,
                    t.status_pembayaran,
                    dp.status_pengiriman
                FROM transaksi t
                JOIN detail_transaksi dt
                    ON t.transaksi_id = dt.transaksi_id
                JOIN hewan_ternak h
                    ON dt.hewan_ternak_id = h.hewan_ternak_id
                LEFT JOIN data_pengiriman dp
                    ON t.transaksi_id = dp.transaksi_id
                WHERE t.user_id = @user_id
                ORDER BY t.transaksi_id DESC";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@user_id",
                    userId);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
        public int GetTotalPesananUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM transaksi t JOIN data_pengiriman dp ON t.transaksi_id = dp.transaksi_id WHERE user_id = @user_id", conn);

                cmd.Parameters.AddWithValue("@user_id", userId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public int GetPesananTerkirimUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM transaksi t JOIN data_pengiriman dp ON t.transaksi_id = dp.transaksi_id WHERE user_id = @user_id AND status_pengiriman = 'Terkirim'", conn);

                cmd.Parameters.AddWithValue("@user_id", userId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetPesananProsesUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM transaksi t JOIN data_pengiriman dp ON t.transaksi_id = dp.transaksi_id WHERE user_id = @user_id AND status_pengiriman = 'Proses'", conn);

                cmd.Parameters.AddWithValue("@user_id", userId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }

}
