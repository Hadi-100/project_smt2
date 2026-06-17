using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class Desa
    {
        public int DesaId { get; set; }
        public int KecamatanId { get; set; }
        public string NamaDesa { get; set; }

        public override string ToString() => NamaDesa;
    }
}
