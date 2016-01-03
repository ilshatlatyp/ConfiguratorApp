using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using ConfiguratorApp.Models.Main;


namespace ConfiguratorApp.Controllers
{
    public class OptionListController : ApiController
    {
        //Получает список опций принадлежажий конкретной компании
        public List<Option> GetOptions(string id)
        {
            ConfiguratorDBContext db = new ConfiguratorDBContext();
            List<Option> OptionList = db.OptionSet.Include(c => c.Company)
                                        .Where(o => o.Company.AccountName == id)
                                        .ToList();            
            return OptionList;
        }
    }
}
