using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ornek.Controllers
{
    public class UrunController : Controller
    {

        // GET: Urun
        Models.Model1 ctx = new Models.Model1();
        public ActionResult Index()
        {
            List<Models.Urunler> urunler = ctx.Urunlers.ToList();
            return View(urunler);
        }
   public ActionResult UrunEkle() {
            ViewBag.kategoriler = ctx.Kategorilers.ToList();
            ViewBag.tedarikciler = ctx.Tedarikcilers.ToList();

            return View();
        }
        //simdi httppost ile formdaki degerleri sql e aktaricaz


        [HttpPost]
        public ActionResult UrunEkle(Models.Urunler u) {
            ctx.Urunlers.Add(u);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        
        }




        public ActionResult UrunSil(int id)
        {

            var urun = ctx.Urunlers.Find(id);
            ctx.Urunlers.Remove(urun);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
       //bu alttai urun silme sayfasina gien action
        public ActionResult Sil(int id)
        {
            Models.Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
            return View(u);
                 
        }
        //bu yazacagimiz action ise urunu silen action
        [HttpPost]
        public ActionResult Sil(Models.Urunler u) {
            Models.Urunler urn = ctx.Urunlers.FirstOrDefault(x => x.UrunID == u.UrunID);
            ctx.Urunlers.Remove(urn);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        
        
        }
    
    }
}