using PassionProject2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassionProject2.Controllers
{
    public class HomeController : Controller
    {
        private TinyHouseEntities3 db = new TinyHouseEntities3();

        public ActionResult Index()
        {
            return View(db.listings2.ToList());
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
        public ActionResult Help()
        {
            ViewBag.Message = "Help";

            return View();
        }
    }
}