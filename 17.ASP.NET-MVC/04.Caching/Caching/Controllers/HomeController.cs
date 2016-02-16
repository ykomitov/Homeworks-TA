using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caching.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [OutputCache(Duration = 120)]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string inputTown)
        {
            FakeDb.towns.Add(inputTown);
            return this.Redirect("~/");
        }

        [OutputCache(Duration = 60 * 60)]
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            ViewBag.Message = DateTime.Now;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}