using Npgsql;
using project_smt2.Helpers;
using System;



namespace project_smt2.Controllers
{

    public class LoginController
    {
        public string Login(string email, string password)
        {
            string role = "Admin";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT role_user
                  FROM users
                  WHERE email=@email
                  AND password=@password";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                    role = result.ToString();
            }

            return role;
        }
    }

}