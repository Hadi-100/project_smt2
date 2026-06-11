using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class Alamat
    {
        public int alamatId { get; set; }
        public string detailAlamat { get; set; }
        public int desaId { get; set; }
        public string kabupaten { get; set; }

        public Alamat(int alamatId, string detailAlamat, int desaId, string kabupaten)
        {
            this.alamatId = alamatId;
            this.detailAlamat = detailAlamat;
            this.desaId = desaId;
            this.kabupaten = kabupaten;
        }
    }
}