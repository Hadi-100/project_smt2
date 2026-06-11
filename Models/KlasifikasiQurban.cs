using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace project_smt2.Models
{
    public class KlasifikasiQurban
    {
        public int klasifikasiQurbanId { get; set; }
        public int kesehatanTernakId { get; set; }
        public string statusQurban { get; set; }
        public DateTime tanggalPemeriksaan { get; set; }
        public string kondisiFisik { get; set; }

        public KlasifikasiQurban(int klasifikasiQurbanId, int kesehatanTernakId,
            string statusQurban, DateTime tanggalPemeriksaan, string kondisiFisik)
        {
            this.klasifikasiQurbanId = klasifikasiQurbanId;
            this.kesehatanTernakId = kesehatanTernakId;
            this.statusQurban = statusQurban;
            this.tanggalPemeriksaan = tanggalPemeriksaan;
            this.kondisiFisik = kondisiFisik;
        }
    }
}
