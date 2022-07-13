using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokData;
using StokDataModel;



namespace StokTakip.Controllers
{
    public class KategoriController : Controller
    {
         Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Kategoriler.ToList();
            return View(degerler);
        }
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori k1)
        {
            context.Kategoriler.Add(k1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var kat = context.Kategoriler.Find(id);
            context.Kategoriler.Remove(kat);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var urun = context.Kategoriler.Find(id);
            return View("KategoriGetir", urun);
        }

        public ActionResult Güncelle(Kategori k1)
        {
            var urun = context.Kategoriler.Find(k1.KategoriId);
            urun.KategoriAd = k1.KategoriAd;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}