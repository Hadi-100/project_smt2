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
                    umur,
                    berat,
                    harga,
                    nama_peternak,
                    status_qurban
                FROM view_hewan_siap_jual";

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