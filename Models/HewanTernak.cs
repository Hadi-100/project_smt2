using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class HewanTernak : Hewan
    {
        public int hewanTernakId { get; set; }

        public string statusHewan { get; set; }

        public HewanTernak(int hewanTernakId, int peternakId, string jenisHewan,
            string jenisKelamin, int umur, int harga, int berat, string statusHewan) : base (hewanTernakId, jenisKelamin, umur, berat, harga)
        {
            this.hewanTernakId = hewanTernakId;
            this.statusHewan = statusHewan;
        }
    }
}
