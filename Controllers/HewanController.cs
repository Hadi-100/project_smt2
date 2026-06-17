using Npgsql;
using System.Data;
using project_smt2.Helpers;
using System.Threading.Tasks.Dataflow;

namespace project_smt2.Controllers
{
    public class HewanController
    {
        public DataTable GetHewan()
        {
            DataTable dt =
                new DataTable();

            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT
                    ht.hewan_ternak_id,
                    jh.nama_jenis,
                    ht.jenis_kelamin,
                    ht.umur,
                    ht.berat,
                    ht.harga,
                    p.nama_peternak,
                    ht.status_hewan,
                    kq.kondisi_fisik,
                    kq.status_qurban
                FROM hewan_ternak ht
                JOIN jenis_hewan jh
                    ON ht.jenis_hewan_id = jh.jenis_hewan_id
                JOIN peternak p
                    ON ht.peternak_id = p.peternak_id
                Join klasifikasi_qurban kq
                    ON kq.hewan_ternak_id = ht.hewan_ternak_id";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(
                        query,
                        conn);

                da.Fill(dt);
            }

            return dt;
        }
        public int GetTotalTersedia()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"
            SELECT COUNT(*)
            FROM hewan_ternak
            WHERE status_hewan = 'Tersedia'
        ", conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalTerjual()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"
            SELECT COUNT(*)
            FROM hewan_ternak
            WHERE status_hewan = 'Terjual'
        ", conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalSapi()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"
            SELECT COUNT(*)
            FROM hewan_ternak ht
            JOIN jenis_hewan jh
                ON ht.jenis_hewan_id = jh.jenis_hewan_id
            WHERE jh.hewan = 'Sapi'
            AND ht.status_hewan = 'Tersedia'
        ", conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public int GetTotalKambing()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"
            SELECT COUNT(*)
            FROM hewan_ternak ht
            JOIN jenis_hewan jh
                ON ht.jenis_hewan_id = jh.jenis_hewan_id
            WHERE jh.hewan = 'Kambing'
            AND ht.status_hewan = 'Tersedia'
        ", conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void TambahkanHewanTernak(
             int jenis_hewan_id,
             string jenis_kelamin,
             int umur,
             int berat,
             int harga,
             int peternak_id)
        {
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand(
                        @"INSERT INTO hewan_ternak
                     (peternak_id, jenis_hewan_id, jenis_kelamin, umur, harga, berat)
                     VALUES
                     (@peternak_id, @jenis_hewan_id, @jenis_kelamin, @umur, @harga, @berat)",
                         conn);

                    cmd.Parameters.AddWithValue("@peternak_id", peternak_id);
                    cmd.Parameters.AddWithValue("@jenis_hewan_id", jenis_hewan_id);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin);
                    cmd.Parameters.AddWithValue("@umur", umur);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@berat", berat);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}