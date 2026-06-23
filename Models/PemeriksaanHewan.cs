using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace project_smt2.Models
{
    public class PemeriksaanHewan
    {
        public int kesehatanTernakId { get; set; }
        public DateTime tanggalPemeriksaan { get; set; }

        public PemeriksaanHewan()
        {

        }

        public PemeriksaanHewan(int kesehatanTernakId, DateTime tanggalPemeriksaan)
        {
            this.kesehatanTernakId = kesehatanTernakId;
            this.tanggalPemeriksaan = tanggalPemeriksaan;
        }
    }
}
