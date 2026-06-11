using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class Peternak
    {
        public int peternakId { get; set; }
        public int alamatId { get; set; }
        public string namaPeternak { get; set; }
        public string nomorTelepon { get; set; }

        public Peternak(int peternakId, int alamatId, string namaPeternak, string nomorTelepon)
        {
            this.peternakId = peternakId;
            this.alamatId = alamatId;
            this.namaPeternak = namaPeternak;
            this.nomorTelepon = nomorTelepon;
        }
    }
}
