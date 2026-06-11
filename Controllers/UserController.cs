using Npgsql;
using System.Data;
using project_smt2.Helpers;
using project_smt2.Models;

namespace project_smt2.Controllers
{
    public class UserController
    {
        public void Register(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"INSERT INTO users
                (
                    user_id,
                    nama_lengkap,
                    email,
                    nomor_telepon,
                    password,
                    role_user
                )
                VALUES
                (
                    @id,
                    @nama,
                    @email,
                    @telepon,
                    @password,
                    'user'
                )";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id",
                    user.UserId);

                cmd.Parameters.AddWithValue("@nama",
                    user.NamaLengkap);

                cmd.Parameters.AddWithValue("@email",
                    user.Email);

                cmd.Parameters.AddWithValue("@telepon",
                    user.NomorTelepon);

                cmd.Parameters.AddWithValue("@password",
                    user.Password);

                cmd.ExecuteNonQuery();
            }
        }

        // Menampilkan daftar user
        public DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT
                    user_id,
                    nama_lengkap,
                    email,
                    nomor_telepon,
                    role_user
                FROM users";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                da.Fill(dt);
            }

            return dt;
  
        }

    }
}
