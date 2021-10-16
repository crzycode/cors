using jobportal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace jobportal.Controllers
{
    public class HomeController : Controller
    {
        JobContext db = new JobContext();
        public ActionResult Index()
        {
            var data = db.users.ToList();
            var json = JsonConvert.SerializeObject(data);

            return Json(json, JsonRequestBehavior.AllowGet);
        }

       
    }

}
