using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class Hewan
    {
        public int HewanTernakId { get; set; }
        public string JenisHewan { get; set; }
        public string JenisKelamin { get; set; }
        public int Umur { get; set; }
        public int Berat { get; set; }
        public int Harga { get; set; }


        public Hewan()
        {

        }

        public Hewan(int hewanTernakId, string jenisHewan, string jenisKelamin, int umur, int berat, int harga)
        {
            HewanTernakId = hewanTernakId;
            JenisHewan = jenisHewan;
            JenisKelamin = jenisKelamin;
            Umur = umur;
            Berat = berat;
            Harga = harga;
        }
    }
}
