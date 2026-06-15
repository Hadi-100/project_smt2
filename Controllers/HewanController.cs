using Npgsql;
using System.Data;
using project_smt2.Helpers;

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
                hewan_ternak_id,
                jenis_hewan,
                jenis_kelamin,
                umur,
                berat,
                harga,
                nama_peternak,
                status_hewan,
                kondisi_fisik,
                status_qurban
                FROM view_list_hewan";

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
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM hewan_ternak WHERE status_hewan = 'Tersedia'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalTerjual()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM hewan_ternak WHERE status_hewan = 'Terjual'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalSapi()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM hewan_ternak WHERE jenis_hewan = 'Sapi' AND status_hewan = 'Tersedia'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalKambing()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM hewan_ternak WHERE jenis_hewan = 'Kambing' AND status_hewan = 'Tersedia'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void TambahkanHewanTernak(
            string jenis_hewan,
            string jenis_kelamin,
            int umur,
            int berat,
            int harga,
            int peternak_id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    @"INSERT INTO hewan_ternak (jenis_hewan, jenis_kelamin, umur, berat, harga, peternak_id)
                      VALUES (@jenis_hewan, @jenis_kelamin, @umur, @berat, @harga, @peternak_id", conn);

                cmd.Parameters.AddWithValue("@jenis_hewan", jenis_hewan);
                cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin);
                cmd.Parameters.AddWithValue("@umur", umur);
                cmd.Parameters.AddWithValue("@berat", berat);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@peternak_id", peternak_id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}