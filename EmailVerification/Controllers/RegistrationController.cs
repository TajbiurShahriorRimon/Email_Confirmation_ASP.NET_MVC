using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmailVerification.Models;

namespace EmailVerification.Controllers
{
    public class RegistrationController : Controller
    {

        UserInfoEntities db = new UserInfoEntities();

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveData(UserSite model)
        {
            this.db.UserSites.Add(model);
            db.SaveChanges();

            return Json("Registration Successful", JsonRequestBehavior.AllowGet);
        }
    }    
}