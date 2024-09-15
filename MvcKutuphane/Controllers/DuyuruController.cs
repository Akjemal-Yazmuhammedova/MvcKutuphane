using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
namespace MvcKutuphane.Controllers
{
    [AllowAnonymous]
    public class DuyuruController : Controller
    {
        // GET: Duyurular
        DBKUTUPHANEEntities db=new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var degerler=db.TBLDUYURULAR.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DuyuruEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DuyuruEkle(TBLDUYURULAR p)
        {
            db.TBLDUYURULAR.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult DuyuruSil(int id)
        {
            var duyuru = db.TBLDUYURULAR.Find(id);
            db.TBLDUYURULAR.Remove(duyuru);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DuyuruGetir(int id)
        {
            var dyr = db.TBLDUYURULAR.Find(id);
            return View("DuyuruGetir", dyr);
        }
        public ActionResult DuyuruGuncelle(TBLDUYURULAR p)
        {
            var dyr = db.TBLDUYURULAR.Find(p.ID);
            dyr.KATEGORI = p.KATEGORI;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}