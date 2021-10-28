using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Promona.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestView()
        {
            return View();
        }
        public string PrintMessage()
        {
            return "<h1>welcome</h1> <p>This is the first custom page of your application</p>";
        }
        public string Play()
        {
            return "<h1>play</h1>";
        }
    }
}