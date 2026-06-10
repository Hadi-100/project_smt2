using Npgsql;
using System.Data;
using project_smt2.Helpers;

namespace project_smt2.Controllers
{
    public class PengirimanController
    {
        public DataTable GetDistribusi()
        {
            DataTable dt =
                new DataTable();

            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT
                    dp.data_pengiriman_id,
                    u.nama_lengkap,
                    dp.tanggal_kirim,
                    dp.biaya_kirim,
                    dp.status_pengiriman
                FROM data_pengiriman dp
                JOIN transaksi t
                ON dp.transaksi_id=t.transaksi_id
                JOIN users u
                ON t.user_id=u.user_id";

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