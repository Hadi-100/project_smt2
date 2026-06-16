using Npgsql;
using project_smt2.Helpers;
using System;



namespace project_smt2.Controllers
{

    public class LoginController
    {
        public string Username { get; private set; }

        public string Login(string email, string password)
        {
            string role = "Admin";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT nama_lengkap, role_user
                  FROM users
                  WHERE email=@email
                  AND password=@password";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())

                    if (reader.Read())
                    {
                        Username = reader.GetString(reader.GetOrdinal("nama_lengkap"));
                        role = reader.GetString(reader.GetOrdinal("role_user"));
                    }
            }

            return role;
        }
    }

}