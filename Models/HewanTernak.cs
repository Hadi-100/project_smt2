using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class HewanTernak : Hewan
    {
        public int PeternakId { get; set; }
            
        public string statusHewan { get; set; }

        public HewanTernak(int peternakId, string statusHewan, int hewanTernakId, string jenisHewan,
            string jenisKelamin, int umur, int harga, int berat) : base (hewanTernakId, jenisHewan, jenisKelamin, umur, berat, harga)
        {
            this.PeternakId = peternakId;
            this.statusHewan = statusHewan;
        }
    }
}
