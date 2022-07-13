using StokData;
using StokDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakip.Controllers
{
    public class MüsteriController : Controller
    {
         Context context = new Context();
        public ActionResult Index()
        {
            var deger = context.Müsteriler.ToList();
            return View(deger);
        }
        public ActionResult MüsteriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MüsteriEkle(Müsteri m1)
        {
            context.Müsteriler.Add(m1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var mstr = context.Müsteriler.Find(id);
            context.Müsteriler.Remove(mstr);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MüsteriGetir(int id)
        {
            var musteri = context.Müsteriler.Find(id);
            return View("MüsteriGetir", musteri);
        }
        public ActionResult Güncelle(Müsteri m1)
        {
            var muster = context.Müsteriler.Find(m1.MüsteriId);
            muster.MüsteriAd = m1.MüsteriAd;
            muster.MüsteriSoyad = m1.MüsteriSoyad;
            context.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}