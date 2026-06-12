using Npgsql;
using System.Data;
using project_smt2.Helpers;
using System.Security.Cryptography.X509Certificates;

namespace project_smt2.Controllers
{
    public class PengirimanController
    {
        public DataTable GetDistribusiHewan()
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

        public int GetTotalTerkirim()
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query =
                @"SELECT COUNT(*) FROM data_pengiriman
                WHERE status_pengiriman= 'Terkirim'";
                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalProses()
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query =
                @"SELECT COUNT(*) FROM data_pengiriman
                WHERE status_pengiriman= 'Proses'";
                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalDistribusi()
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query =
                @"SELECT COUNT(*) FROM data_pengiriman";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}