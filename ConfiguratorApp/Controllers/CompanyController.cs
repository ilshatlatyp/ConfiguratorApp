using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConfiguratorApp.Models.Main;

namespace ConfiguratorApp.Controllers
{
    public class CompanyController : Controller
    {
        ConfiguratorDBContext db = new ConfiguratorDBContext();
        // GET: Company
        public ActionResult Index(string companyName)
        {         
            Company company = db.EFCompany.Where(c=>c.AccountName == companyName).First();
            return View(company);
        }
    }
}