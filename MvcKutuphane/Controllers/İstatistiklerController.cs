using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class İstatistiklerController : Controller
    {
        // GET: İstatistikler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hava()
        { 
            return View(); 
        }
        public ActionResult Galeri()
        {
            return View();
        }
        public ActionResult LinqKart()
        {
            return View();
        }
    }
}