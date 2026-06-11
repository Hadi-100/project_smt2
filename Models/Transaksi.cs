using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public class Transaksi
    {
        public int transaksiId { get; set; }
        public int userId { get; set; }
        public int alamatId { get; set; }
        public DateTime tanggalTransaksi { get; set; }
        public string statusPembayaran { get; set; }

        public Transaksi(int transaksiId, int userId, int alamatId,
            DateTime tanggalTransaksi, string statusPembayaran)
        {
            this.transaksiId = transaksiId;
            this.userId = userId;
            this.alamatId = alamatId;
            this.tanggalTransaksi = tanggalTransaksi;
            this.statusPembayaran = statusPembayaran;
        }
    }
}
