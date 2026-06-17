using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class Kecamatan
    {
        public int KecamatanId { get; set; }
        public string NamaKecamatan { get; set; }

        public override string ToString() => NamaKecamatan;
    }
}
