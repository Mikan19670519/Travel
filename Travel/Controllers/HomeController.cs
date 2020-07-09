using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Write a blog:";

            return View();
        }

        public ActionResult Flights()
        {
            ViewBag.Message = "View all flights:";

            return View();
        }

        public ActionResult Hotels()
        {
            ViewBag.Message = "See all Hotels available:";

            return View();
        }

        public ActionResult Holidays()
        {
            ViewBag.Message = "View holidays and specials:";

            return View();
        }
    }
}