using Npgsql;
using project_smt2.Models;
using System.Collections.Generic;
using project_smt2.Helpers;

namespace project_smt2.Contexts
{
    public class UserContext
    {

        public User GetUserByEmail(string email)
        {
            User user = null;

            using var conn = DatabaseHelper.GetConnection();
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
            using var conn = DatabaseHelper.GetConnection();
            {
                conn.Open();

                string query =
                @"INSERT INTO users
                (
                    nama_lengkap,
                    email,
                    password,
                    role_user
                )
                VALUES
                (
                    @nama,
                    @email,
                    @password,
                    @role
                )";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

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

            using var conn = DatabaseHelper.GetConnection();
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