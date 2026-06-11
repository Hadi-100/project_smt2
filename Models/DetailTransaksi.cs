using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public class DetailTransaksi
    {
        public int detailTransaksiId { get; set; }
        public int transaksiId { get; set; }
        public int hewanTernakId { get; set; }
        public int hargaJual { get; set; }
        public int quantity { get; set; }
        public int subtotal { get; set; }

        public DetailTransaksi(int detailTransaksiId, int transaksiId,
            int hewanTernakId, int hargaJual, int quantity, int subtotal)
        {
            this.detailTransaksiId = detailTransaksiId;
            this.transaksiId = transaksiId;
            this.hewanTernakId = hewanTernakId;
            this.hargaJual = hargaJual;
            this.quantity = quantity;
            this.subtotal = subtotal;
        }
    }
}