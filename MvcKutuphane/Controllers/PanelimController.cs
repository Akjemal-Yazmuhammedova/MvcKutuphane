using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    [Authorize]
    public class PanelimController : Controller
    {
        // GET: Panelim
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        
        
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBLUYELER p)
        {
            var kullanici = (string)Session["Mail"];
            var uye = db.TBLUYELER.FirstOrDefault(x => x.MAIL == kullanici);
            TempData["id"] = uye.ID;
            TempData["Soyad"] = uye.SOYAD;
            TempData["KAdi"] = uye.KULLANICIADI;
            TempData["Sifre"] = uye.SIFRE;
            TempData["Okul"] = uye.OKUL;
            TempData["Ad"] = uye.AD;

            uye.SIFRE = p.SIFRE;
            db.SaveChanges();
            return View();
        }
        public ActionResult Kitaplarim()
        {
            return View();
        }
    }
}