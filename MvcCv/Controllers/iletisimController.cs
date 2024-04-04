using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<Tbliletisim> repo = new GenericRepository<Tbliletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }

        public ActionResult iletisimSil(int id)
        {
            var mesajlar = repo.Find(x => x.ID == id);
            repo.TDelete(mesajlar);
            return RedirectToAction("Index");
        }
    }
}