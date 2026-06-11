using Npgsql;
using project_smt2.Models;
using System.Collections.Generic;

namespace project_smt2.Contexts
{
    public class UserContext
    {
        private string connString =
            "Host=localhost;Port=5432;Username=postgres;Password=Alhadi2007;Database=revisi_db_terbaru";

        public User GetUserByEmail(string email)
        {
            User user = null;

            using (NpgsqlConnection conn =
                new NpgsqlConnection(connString))
            {
                conn.Open();

                string query =
                    @"SELECT *
                      FROM users
                      WHERE email = @email";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@email", email);

                NpgsqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new User()
                    {
                        UserId = Convert.ToInt32(
                            reader["user_id"]),

                        NamaLengkap =
                            reader["nama_lengkap"].ToString(),

                        Email =
                            reader["email"].ToString(),

                        Password =
                            reader["password"].ToString(),

                        RoleUser =
                            reader["role_user"].ToString()
                    };
                }
            }

            return user;
        }

        public bool Insert(User user)
        {
            using (NpgsqlConnection conn =
                new NpgsqlConnection(connString))
            {
                conn.Open();

                string query =
                @"INSERT INTO users
                (
                    user_id,
                    nama_lengkap,
                    email,
                    password,
                    role_user
                )
                VALUES
                (
                    @id,
                    @nama,
                    @email,
                    @password,
                    @role
                )";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    user.UserId);

                cmd.Parameters.AddWithValue(
                    "@nama",
                    user.NamaLengkap);

                cmd.Parameters.AddWithValue(
                    "@email",
                    user.Email);

                cmd.Parameters.AddWithValue(
                    "@password",
                    user.Password);

                cmd.Parameters.AddWithValue(
                    "@role",
                    user.RoleUser);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<User> GetAll()
        {
            List<User> users =
                new List<User>();

            using (NpgsqlConnection conn =
                new NpgsqlConnection(connString))
            {
                conn.Open();

                string query =
                    "SELECT * FROM users";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                NpgsqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(
                        new User(
                        Convert.ToInt32(reader["user_id"]),
                        reader["nama_lengkap"].ToString(),
                        reader["email"].ToString(),
                        reader["nomor_telepon"].ToString(),
                        reader["password"].ToString(),
                        reader["role_user"].ToString()
                        )
                    );
                }
            }

            return users;
        }
    }
}