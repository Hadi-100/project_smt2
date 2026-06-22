using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace project_smt2.Models
{
    public class KlasifikasiQurban : PemeriksaanHewan
    {
        public int klasifikasiQurbanId { get; set; }
        public string statusQurban { get; set; }
        public string kondisiFisik { get; set; }

        public KlasifikasiQurban(int klasifikasiQurbanId, int kesehatanTernakId,
            string statusQurban, DateTime tanggalPemeriksaan, string kondisiFisik) : base (kesehatanTernakId, tanggalPemeriksaan)
        {
            this.klasifikasiQurbanId = klasifikasiQurbanId;
            this.statusQurban = statusQurban;
            this.kondisiFisik = kondisiFisik;
        }
    }
}
