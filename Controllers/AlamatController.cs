using Npgsql;
using project_smt2.Helpers;
using project_smt2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Controllers
{
    public class AlamatController
    {
        public List<Kecamatan> GetAllKecamatan()
        {
            var list = new List<Kecamatan>();

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string sql = "SELECT kecamatan_id, nama_kecamatan FROM kecamatan ORDER BY nama_kecamatan";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Kecamatan
                {
                    KecamatanId = reader.GetInt32(0),
                    NamaKecamatan = reader.GetString(1)
                });
            }

            return list;
        }
        public List<Desa> GetDesaByKecamatan(int kecamatanId)
        {
            var list = new List<Desa>();

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string sql = @"SELECT desa_id, kecamatan_id, nama_desa 
                       FROM desa 
                       WHERE kecamatan_id = @kecamatanId 
                       ORDER BY nama_desa";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kecamatanId", kecamatanId);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Desa
                {
                    DesaId = reader.GetInt32(0),
                    KecamatanId = reader.GetInt32(1),
                    NamaDesa = reader.GetString(2)
                });
            }

            return list;
        }

        public int InsertAlamat(string detailAlamat, int desaId)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO alamat (detail_alamat, desa_id, kabupaten) 
                       VALUES (@detail, @desaId, 'Jember') 
                       RETURNING alamat_id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@detail", detailAlamat);
            cmd.Parameters.AddWithValue("@desaId", desaId);

            return (int)cmd.ExecuteScalar();
        }
    }
}
