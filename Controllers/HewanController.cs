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
                @"SELECT
                ht.hewan_ternak_id,
                jh.hewan AS jenis_hewan,
                ht.jenis_kelamin,
                ht.umur,
                ht.berat,
                ht.harga,
                p.nama_peternak,
                ht.status_hewan
                FROM hewan_ternak ht
                LEFT JOIN jenis_hewan jh ON ht.jenis_hewan_id = jh.jenis_hewan_id
                LEFT JOIN peternak p ON ht.peternak_id = p.peternak_id";

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
            {
                string query = @"SELECT
                        ht.hewan_ternak_id,
                        jh.hewan AS jenis_hewan,
                        ht.jenis_kelamin,
                        ht.umur,
                        ht.berat,
                        ht.harga,
                        p.nama_peternak,
                        ht.status_hewan,
                     FROM hewan_ternak ht
                     LEFT JOIN jenis_hewan jh ON ht.jenis_hewan_id = jh.jenis_hewan_id
                     LEFT JOIN peternak p ON ht.peternak_id = p.peternak_id";

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                return dt;
            }
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
                    "SELECT COUNT(*) FROM hewan_ternak ht JOIN jenis_hewan jh ON jh.jenis_hewan_id = ht.jenis_hewan_id WHERE jh.hewan = 'Sapi' AND ht.status_hewan = 'Tersedia'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalKambing()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM hewan_ternak ht JOIN jenis_hewan jh ON jh.jenis_hewan_id = ht.jenis_hewan_id WHERE jh.hewan = 'Kambing' AND ht.status_hewan = 'Tersedia'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void TambahkanHewanTernak(
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
     DateTime tanggal_pemeriksaan
 )
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new NpgsqlCommand(
                            @"UPDATE hewan_ternak 
          SET jenis_hewan_id = @jenis_hewan_id, 
              peternak_id = @peternak_id, 
              jenis_kelamin = @jenis_kelamin, 
              umur = @umur, 
              berat = @berat, 
              harga = @harga 
          WHERE hewan_ternak_id = @hewan_ternak_id", conn))
                        {
                            cmd.Parameters.AddWithValue("@jenis_hewan_id", jenis_hewan_id);
                            cmd.Parameters.AddWithValue("@peternak_id", peternak_id);
                            cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin);
                            cmd.Parameters.AddWithValue("@umur", umur);
                            cmd.Parameters.AddWithValue("@berat", berat);
                            cmd.Parameters.AddWithValue("@harga", harga);
                            cmd.Parameters.AddWithValue("@hewan_ternak_id", hewan_ternak_id);

                            int rowsHewan = cmd.ExecuteNonQuery();
                            MessageBox.Show($"[DEBUG 1] Berhasil update tabel hewan_ternak sebanyak: {rowsHewan} baris. (IDTarget: {hewan_ternak_id})", "Debug Info");
                        }

                        string statusQurban = "Tidak Layak";
                        if ((jenis_hewan_id == 1 || jenis_hewan_id == 3 || jenis_hewan_id == 4) && umur >= 2)
                        {
                            statusQurban = "Layak";
                        }
                        else if ((jenis_hewan_id == 2 || jenis_hewan_id == 5 || jenis_hewan_id == 6 || jenis_hewan_id == 7) && umur >= 1)
                        {
                            statusQurban = "Layak";
                        }

                        if (kondisi_fisik == "Sakit" || kondisi_fisik == "Cacat Berat")
                        {
                            statusQurban = "Tidak Layak";
                        }

                        using (var cmdUpdate = new NpgsqlCommand(
                            @"UPDATE klasifikasi_qurban 
          SET kondisi_fisik = @kondisi_fisik::kondisi_fisik, 
              status_qurban = @status_qurban::status_qurban,
              tanggal_pemeriksaan = @tanggal_pemeriksaan 
          WHERE hewan_ternak_id = @hewan_ternak_id", conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@kondisi_fisik", kondisi_fisik ?? "Sehat");
                            cmdUpdate.Parameters.AddWithValue("@status_qurban", statusQurban);
                            cmdUpdate.Parameters.AddWithValue("@tanggal_pemeriksaan", tanggal_pemeriksaan);
                            cmdUpdate.Parameters.AddWithValue("@hewan_ternak_id", hewan_ternak_id);

                            int rows = cmdUpdate.ExecuteNonQuery();

                            if (rows == 0)
                            {
                                using (var cmdInsert = new NpgsqlCommand(
                                    @"INSERT INTO klasifikasi_qurban (hewan_ternak_id, kondisi_fisik, status_qurban, tanggal_pemeriksaan) 
                  VALUES (@hewan_ternak_id, @kondisi_fisik::kondisi_fisik, @status_qurban::status_qurban, @tanggal_pemeriksaan)", conn))
                                {
                                    cmdInsert.Parameters.AddWithValue("@hewan_ternak_id", hewan_ternak_id);
                                    cmdInsert.Parameters.AddWithValue("@kondisi_fisik", kondisi_fisik ?? "Sehat");
                                    cmdInsert.Parameters.AddWithValue("@status_qurban", statusQurban);
                                    cmdInsert.Parameters.AddWithValue("@tanggal_pemeriksaan", tanggal_pemeriksaan);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }

                        tran.Commit();
                    }

                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show($"[DEBUG 4] TERJADI ERROR, TRANSAKSI DI-ROLLBACK! Error: {ex.Message}", "Debug Error");
                    }
            }
        }
    }
}}