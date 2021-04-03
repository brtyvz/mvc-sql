using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ornek.Controllers
{
    public class TedarikciController : Controller
    {

        // GET: Tedarikci
        Models.Model1 ctx = new Models.Model1();
        public ActionResult Index()
        {
            List<Models.Tedarikciler> data = ctx.Tedarikcilers.ToList();

            return View(data);
        }

        [HttpPost]
        public void Sil(int id) {
            Models.Tedarikciler t = ctx.Tedarikcilers.FirstOrDefault(x => x.TedarikciID == id);
            ctx.Tedarikcilers.Remove(t);
            ctx.SaveChanges();
          
        
        }
    }
}