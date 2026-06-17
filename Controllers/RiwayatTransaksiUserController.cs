using Npgsql;
using project_smt2.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace project_smt2.Controllers
{
    public class RiwayatTransaksiUserController
    {
        public DataTable GetRiwayatTransaksiUser(int userId)
        {
            DataTable dt = new DataTable();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT
                t.transaksi_id,
                t.tanggal_transaksi,
                
                t.status_pembayaran
            FROM transaksi t
            WHERE t.user_id = @user_id
            ORDER BY t.tanggal_transaksi DESC";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@user_id",
                    userId);

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }

        public int GetTotalTransaksiUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM transaksi WHERE user_id = @user_id", conn);

                cmd.Parameters.AddWithValue("@user_id", userId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public int GetTotalSudahLunasUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(transaksi_id) FROM transaksi WHERE user_id = @user_id AND status_pembayaran = 'Lunas'", conn);

                cmd.Parameters.AddWithValue("@user_id", userId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public int GetTotalBelumBayarUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(transaksi_id) FROM transaksi WHERE user_id = @user_id AND status_pembayaran = 'Belum Lunas'", conn);

                cmd.Parameters.AddWithValue("@user_id", userId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}
