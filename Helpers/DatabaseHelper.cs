using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace project_smt2.Helpers
{
    public class DatabaseHelper
    {
        private static string connectionString =
            "Host=localhost;" + "Port=5432;" + "Database=revisi_db_terbaru;" + "Username=postgres;" + "Password=Alhadi2007;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
