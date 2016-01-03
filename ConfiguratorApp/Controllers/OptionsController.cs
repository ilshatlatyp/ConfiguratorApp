using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ConfiguratorApp.Models.Main;
using Newtonsoft.Json;

namespace ConfiguratorApp.Controllers
{
    public class OptionsController : Controller
    {

        ConfiguratorDBContext db = new ConfiguratorDBContext();
        // GET: Options
        public ActionResult Index()
        {
            string account = RouteData.Values["id"].ToString();
            ViewBag.account = account;

            return View();
        }
    }
}