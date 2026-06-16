using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using project_smt2.Helpers;

namespace project_smt2.Helpers
{
    public class DatabaseHelper
    {
        private static string connectionString =
            "Host=localhost;" + "Port=5432;" + "Database=project_revisi;" + "Username=postgres;" + "Password=Alhadi2007;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
