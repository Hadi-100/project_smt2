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

        }

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
