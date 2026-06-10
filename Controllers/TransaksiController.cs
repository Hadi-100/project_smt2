using Npgsql;
using System.Data;
using project_smt2.Helpers;

namespace project_smt2.Controllers
{
    public class TransaksiController
    {
        public DataTable GetRiwayat()
        {
            DataTable dt =
                new DataTable();

            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT
                    t.transaksi_id,
                    u.nama_lengkap,
                    t.tanggal_transaksi,
                    dt.harga_jual,
                    dt.subtotal,
                    t.status_pembayaran
                FROM transaksi t
                JOIN users u
                ON t.user_id=u.user_id
                JOIN detail_transaksi dt
                ON t.transaksi_id=dt.transaksi_id";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(
                        query,
                        conn);

                da.Fill(dt);
            }

            return dt;
        }
    }
}