using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ornek.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Models.Model1 ctx = new Models.Model1();

        public ActionResult Index()
        {
            List<Models.Kategoriler> ktg = ctx.Kategorilers.ToList();
            return View(ktg);
        }
    public ActionResult  Ekle()
        {


            return View();
        }
    [HttpPost]
    public ActionResult Ekle(Models.Kategoriler k)
        {
            ctx.Kategorilers.Add(k);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }
       [HttpPost]
    public void Sil(int id)
        {
            Models.Kategoriler k = ctx.Kategorilers.FirstOrDefault(x => x.KategoriID == id);
            ctx.Kategorilers.Remove(k);
            ctx.SaveChanges();
               

           
        }
    }
}