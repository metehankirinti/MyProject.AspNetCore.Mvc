using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_8.Models;

namespace Project_8.Controllers
{
    public class HomeController : Controller
    {

        aracEntities2 db = new aracEntities2();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Araclar()
        {
            var araclar = db.hancars.ToList();
            return View(araclar);
        }
        public ActionResult AracDetay(int id)
        {
            var arac = db.hancars.FirstOrDefault(x => x.aracid == id);
            ViewBag.data=arac;
            return View("AracDetay",arac);
        }

        public ActionResult Marka()
        {
            var araclar = db.hancars.ToList();
            return View(araclar);
        }


    }
}