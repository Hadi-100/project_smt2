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
                dl.harga_jual,
                t.status_pembayaran
                FROM transaksi t
                JOIN users u ON t.user_id = u.user_id
                JOIN detail_transaksi dl ON t.transaksi_id = dl.transaksi_id";
                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(
                        query,
                        conn);

                da.Fill(dt);
            }

            return dt;
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

        public int GetTotalBelumBayar()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(transaksi_id) FROM transaksi WHERE status_pembayaran = 'Belum Lunas'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalSudahLunas()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(transaksi_id) FROM transaksi WHERE status_pembayaran = 'Lunas'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public long GetNilaiTotal()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    @"SELECT COALESCE(SUM(dl.harga_jual), 0)
              FROM transaksi t
              JOIN detail_transaksi dl ON t.transaksi_id = dl.transaksi_id", conn);
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        public void InsertTransaksiDanDetail(
    int userId,
    int alamatId,
    int hewanId,
    decimal harga)
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                using (var trans =
                    conn.BeginTransaction())
                {
                    try
                    {
                        int transaksiId;

                        string queryTransaksi = @"
                INSERT INTO transaksi
                (
                    user_id,
                    alamat_id,
                    tanggal_transaksi,
                    status_pembayaran
                )
                VALUES
                (
                    @userId,
                    @alamatId,
                    CURRENT_DATE,
                    'Lunas'
                )
                RETURNING transaksi_id";

                        using (var cmd =
                            new NpgsqlCommand(
                                queryTransaksi,
                                conn))
                        {
                            cmd.Transaction = trans;

                            cmd.Parameters.AddWithValue(
                                "@userId",
                                userId);

                            cmd.Parameters.AddWithValue(
                                "@alamatId",
                                alamatId);

                            transaksiId =
                                Convert.ToInt32(
                                    cmd.ExecuteScalar());
                        }

                        string queryDetail = @"
                INSERT INTO detail_transaksi
                (
                    transaksi_id,
                    hewan_ternak_id,
                    harga_jual
                )
                VALUES
                (
                    @transaksiId,
                    @hewanId,
                    @harga
                )";

                        using (var cmd =
                            new NpgsqlCommand(
                                queryDetail,
                                conn))
                        {
                            cmd.Transaction = trans;

                            cmd.Parameters.AddWithValue(
                                "@transaksiId",
                                transaksiId);

                            cmd.Parameters.AddWithValue(
                                "@hewanId",
                                hewanId);

                            cmd.Parameters.AddWithValue(
                                "@harga",
                                harga);

                            cmd.ExecuteNonQuery();
                        }

                        string queryUpdate = @"
                UPDATE hewan_ternak
                SET status_hewan='Terjual'
                WHERE hewan_ternak_id=@id";

                        using (var cmd =
                            new NpgsqlCommand(
                                queryUpdate,
                                conn))
                        {
                            cmd.Transaction = trans;

                            cmd.Parameters.AddWithValue(
                                "@id",
                                hewanId);

                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }


        }
    }
        
    
}