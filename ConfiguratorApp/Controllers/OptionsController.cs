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
        public ActionResult Index()//(string account)
        {
            //List<Option> OptionList = db.OptionSet.Include(c => c.Company)
            //                            .Where(o => o.Company.AccountName == account)
            //                            .ToList();
            //string s = JsonConvert.SerializeObject(OptionList); 
            //return View(s);
            return View();
        }
    }
}