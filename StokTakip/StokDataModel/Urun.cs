using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokDataModel
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int UrunKategori { get; set; }
        public int Fiyat { get; set; }
        public string Marka { get; set; }
        public int Stok { get; set; }


    }
}
