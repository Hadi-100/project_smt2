using Npgsql;
using project_smt2.Helpers;
using System;

namespace project_smt2.Controllers
{
    public class DashboardController
    {
        public int GetTotalUser()
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM users WHERE role_user='user'";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                return Convert.ToInt32(
                    cmd.ExecuteScalar());
            }
        }

        public int GetTotalHewan()
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM hewan_ternak";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                return Convert.ToInt32(
                    cmd.ExecuteScalar());
            }
        }

        public decimal GetPendapatan()
        {
            using (var conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT COALESCE(
                    SUM(subtotal),0)
                  FROM detail_transaksi";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                return Convert.ToDecimal(
                    cmd.ExecuteScalar());
            }
        }
    }
}
