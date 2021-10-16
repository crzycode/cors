using jobportal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace jobportal.Controllers
{
    public class RegisterController : Controller
    {
        JobContext db = new JobContext();
        [HttpPost]
        public ActionResult Index(user u)
        {
           
            db.users.Add(u);
            int a = db.SaveChanges();
            if(a > 0)
            {
                ViewBag.InsertMessage = "<script>alert('data inserted')</script>";
            }
            else
            {
                ViewBag.InsertMessage = "<script>alert('data notinserted')</script>";
            }
            var message = "successfull";
            var json = JsonConvert.SerializeObject(message);

            return Json(json, JsonRequestBehavior.AllowGet);
        }
    [HttpPost]
        public ActionResult Login(user u)
        {

        /*    var user = db.users.Where(model => model.email == u.email && model.number == u.number).FirstOrDefault();*/
            var email = db.users.Where(model => model.email == u.email).FirstOrDefault();
            var number = db.users.Where(model => model.number == u.number).FirstOrDefault();
            
            if (email != null)
            {
             
                string useremail = "email is registered";
                Session["useremail"] = useremail;






            }
            else
            {
                string useremail = "email is not registered";
                Session["useremail"] = useremail;
            }

            if (number != null)
            {

                string mobile = "mobile is registered";
                Session["mobile"] = mobile;





            }
            else
            {
                string mobile = "mobile is not registered";
                Session["mobile"] = mobile;
            }
          
            var json = JsonConvert.SerializeObject(new {message = Session["useremail"].ToString(), kamal = Session["mobile"].ToString() });
            return Json(json, JsonRequestBehavior.AllowGet);

           /* Session.Remove("useremail");
            Session.Remove("mobile");*/


        }
    }
}