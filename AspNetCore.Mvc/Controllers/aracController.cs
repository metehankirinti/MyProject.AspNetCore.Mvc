using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_8.Models;

namespace Project_8.Controllers
{
    public class aracController : Controller
    {
        // GET: arac
        aracEntities2 db = new aracEntities2();
        public ActionResult Index()
        {
            var araclar=db.hancars.ToList();
            return View(araclar);
        }
        [HttpGet]
        public ActionResult AracEkle ()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult AracEkle(hancars t)
        {
            db.hancars.Add(t);
            db.SaveChanges();   
            return RedirectToAction("Index");
        }

        public ActionResult Aracsil(int id)
        {
            var arac = db.hancars.Find(id);
            db.hancars.Remove(arac);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Aracgüncelle(int id)
        {
            var araba = db.hancars.Find(id);
            return View("Aracgüncelle", araba);
        }
        [HttpPost]
        public ActionResult Aracgüncellee(hancars t)
        {

            var araba =db.hancars.Find(t.aracid);
            araba.marka = t.marka;
            araba.model = t.model;
            araba.Renk = t.Renk;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}