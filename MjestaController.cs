using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Promona.Controllers
{
    public class MjestaController : Controller
    {
        // GET: Mjesta
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Gradovi()
        {
            //ViewBag.Gradovi = new List<string> { "Split", "Sibenik", "Zadar" };
            //return View();

            //List<string> ListofGradovi = new List<string>();
            //ViewBag.gradovi.Add("Split");
            //ViewBag.gradovi.Add("Sibnik");
            //ViewBag.gradovi.Add("Zadar");

            //ViewBag.ListGradovi = ListofGradovi;

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);

            ViewBag.GradoviLista = cities;

            //return View();
            //ViewBag.Gradovi = new List<string>()
            //{
            //    "Split", "Sibenik", "Omis"
            //};

            //return View();

            //return "Split je najbolji grad";

            //ViewBag.Message = "Your contact page.";

            return View();


        }
        public string PrintGradovi()
        {
            return "<h1>split</h1>";
        }
        
    }
}
