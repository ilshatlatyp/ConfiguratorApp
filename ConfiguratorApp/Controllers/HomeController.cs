using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConfiguratorApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Models.Main.ConfiguratorDBContext db = new Models.Main.ConfiguratorDBContext();
            //Company c = db.CompanySet.First();
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
    }
}