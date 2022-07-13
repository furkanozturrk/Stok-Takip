using StokDataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokData
{
    public class MyInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            Kategori kat = new Kategori()
            {
                KategoriId = 1,
                KategoriAd = "Beyaz Eşya",
            };
            context.Kategoriler.Add(kat);
            Kategori kat1 = new Kategori()
            {
                KategoriId = 2,
                KategoriAd = "Küçük Ev Aletleri",
            };
            context.Kategoriler.Add(kat1);
            Kategori kat2 = new Kategori()
            {
                KategoriId = 3,
                KategoriAd = "Bilgisayar",
            };
            context.Kategoriler.Add(kat2);
            Müsteri müs = new Müsteri()
            {
                MüsteriId=1,
                MüsteriAd="Mehmet",
                MüsteriSoyad="Polat",
            };
            context.Müsteriler.Add(müs);
            Müsteri müs1 = new Müsteri()
            {
                MüsteriId = 2,
                MüsteriAd = "Oguzhan",
                MüsteriSoyad = "Tekin",
            };
            context.Müsteriler.Add(müs1);
            Müsteri müs2 = new Müsteri()
            {
                MüsteriId = 2,
                MüsteriAd = "Nurdan",
                MüsteriSoyad = "Keskin",
            };
            context.Müsteriler.Add(müs2);
            Urun urun = new Urun()
            {
                UrunId = 1,
                UrunAd = "Çamaşır Makinası",
                UrunKategori = 1,
                Fiyat = 1100,
                Marka="Arçelik",
                Stok=10,
            };
            context.Urunler.Add(urun);
            Urun urun1 = new Urun()
            {
                UrunId = 2,
                UrunAd = "Bulaşık Makinası",
                UrunKategori = 1,
                Fiyat = 700,
                Marka = "Arçelik",
                Stok = 6,
            };
            context.Urunler.Add(urun1);
            Urun urun2 = new Urun()
            {
                UrunId = 2,
                UrunAd = "Su Isıtıcı",
                UrunKategori = 2,
                Fiyat = 100,
                Marka = "Vestel",
                Stok = 80,
            };
            context.Urunler.Add(urun2);

            context.SaveChanges();
        }
    }
}
