using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace project_smt2.Helpers
{
    public class DatabaseHelper
    {
        private static string connectionString =
            "Host=localhost;" + "Port=5432;" + "Database=P;" + "Username=postgres;" + "Password=Anindya.1;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
