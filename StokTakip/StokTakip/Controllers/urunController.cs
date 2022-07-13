using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokData;
using StokDataModel;

namespace StokTakip.Controllers
{
    public class urunController : Controller
    {
         Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Urunler.ToList();
            return View(degerler);
        }
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun u1)
        {
            context.Urunler.Add(u1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var urun = context.Urunler.Find(id);
            context.Urunler.Remove(urun);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = context.Urunler.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult Güncelle(Urun u1)
        {
            var urun = context.Urunler.Find(u1.UrunId);
            urun.UrunId = u1.UrunId;
            urun.UrunAd = u1.UrunAd;
            urun.UrunKategori = u1.UrunKategori;
            urun.Fiyat = u1.Fiyat;
            urun.Marka = u1.Marka;
            urun.Stok = u1.Stok;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}