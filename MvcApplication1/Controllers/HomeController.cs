using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcApplication1.Scripts.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        ProjekatEntities2 _db = new ProjekatEntities2();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Model = _db.tbl_Komentar.ToList();
            //Home komentar = new Home(){
            
                //Korisnicko_ime = "Mama",
                //Datum = "Četvrtak, 02. 07. 2015. 15:24h",
                //Komentar = "Sedam puta vise sluzbenih automobila od Nemacke, taman proporcionalno jer smo 77 puta siromasniji od Nemacke."

            //};
            //List<Home> komentari = komContext.Home.toList();

            //return View(komentar);
            //return View(komentari);
            return View();
        }

       /* [HttpPost]
         public ActionResult Index(Home komToAdd)
        {
            var userValue = Request.Form["username"];
            var comValue = Request.Form["comment"];
            komToAdd.Korisnicko_ime = userValue;
            komToAdd.Sadrzaj = comValue;
            komToAdd.Br_plus = 2;
            komToAdd.Br_minus =3;

                return RedirectToAction("Index");
            }*/



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
