using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class HewanTernak
    {
        public int hewanTernakId { get; set; }
        public int peternakId { get; set; }
        public string jenisHewan { get; set; }
        public string jenisKelamin { get; set; }
        public int umur { get; set; }
        public int harga { get; set; }
        public int berat { get; set; }
        public string statusHewan { get; set; }

        public HewanTernak(int hewanTernakId, int peternakId, string jenisHewan,
            string jenisKelamin, int umur, int harga, int berat, string statusHewan)
        {
            this.hewanTernakId = hewanTernakId;
            this.peternakId = peternakId;
            this.jenisHewan = jenisHewan;
            this.jenisKelamin = jenisKelamin;
            this.umur = umur;
            this.harga = harga;
            this.berat = berat;
            this.statusHewan = statusHewan;
        }
    }
}
