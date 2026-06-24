    using Npgsql;
using project_smt2.Helpers;
using System.Collections;
using System.Data;

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
                @"SELECT * FROM view_list_hewan";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(
                        query,
                        conn);

                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetHewanById(int hewan_ternak_id)
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"SELECT * FROM view_list_hewan_id
                    WHERE hewan_ternak_id = @id", conn);

                cmd.Parameters.AddWithValue("@id", hewan_ternak_id);
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public int GetTotalTersedia()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"SELECT * FROM view_total_hewan_tersedia", conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalTerjual()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"
            SELECT * FROM view_total_hewan_terjual", conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalSapi()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT * FROM view_total_sapi_tersedia", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public int GetTotalKambing()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT * FROM view_total_kambing_tersedia", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void TambahkanHewan(
            int jenis_hewan_id,
            int peternak_id,
            string jenis_kelamin,
            int umur,
            int berat,
            int harga
            )
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    @"INSERT INTO hewan_ternak (peternak_id, jenis_hewan_id, jenis_kelamin, umur, berat, harga)
                      VALUES (@peternak_id, @jenis_hewan_id, @jenis_kelamin, @umur, @berat, @harga)", conn);

                cmd.Parameters.AddWithValue("@jenis_hewan_id", jenis_hewan_id);
                cmd.Parameters.AddWithValue("@peternak_id", peternak_id);
                cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin);
                cmd.Parameters.AddWithValue("@umur", umur);
                cmd.Parameters.AddWithValue("@berat", berat);
                cmd.Parameters.AddWithValue("@harga", harga);

                int affected = cmd.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine($"InsertHewan: hewan_ternak affected={affected}, peternak_id={peternak_id}, jenis_hewan_id={jenis_hewan_id}");
            }
        }

        public void UpdateHewan(
            int hewan_ternak_id,
            int peternak_id,
            int jenis_hewan_id,
            string jenis_kelamin,
            int umur,
            int berat,
            int harga,
            string kondisi_fisik,
            DateTime? tanggal_pemeriksaan)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("CALL update_hewan_dan_qurban(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", conn))
                    {
                        cmd.Parameters.AddWithValue("@p1", hewan_ternak_id);
                        cmd.Parameters.AddWithValue("@p2", peternak_id);
                        cmd.Parameters.AddWithValue("@p3", jenis_hewan_id);
                        cmd.Parameters.AddWithValue("@p4", jenis_kelamin);
                        cmd.Parameters.AddWithValue("@p5", umur);
                        cmd.Parameters.AddWithValue("@p6", berat);
                        cmd.Parameters.AddWithValue("@p7", harga);
                        cmd.Parameters.AddWithValue("@p8", kondisi_fisik ?? "Sehat");

                        cmd.Parameters.AddWithValue("@p9", (object)tanggal_pemeriksaan ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"TERJADI ERROR! Error: {ex.Message}", "Debug Error");
                }
            }
        }
    }
}