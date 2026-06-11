using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public class Pengiriman
    {
        public int dataPengirimanId { get; set; }
        public int transaksiId { get; set; }
        public int biayaKirim { get; set; }
        public DateTime tanggalKirim { get; set; }
        public string statusPengiriman { get; set; }

        public Pengiriman(int dataPengirimanId, int transaksiId,
            int biayaKirim, DateTime tanggalKirim, string statusPengiriman)
        {
            this.dataPengirimanId = dataPengirimanId;
            this.transaksiId = transaksiId;
            this.biayaKirim = biayaKirim;
            this.tanggalKirim = tanggalKirim;
            this.statusPengiriman = statusPengiriman;
        }
    }
}
