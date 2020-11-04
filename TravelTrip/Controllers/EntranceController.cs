using System;
using System.Collections.Generic;
using System.Linq;
using TravelTrip.Models.Classes;
using System.Web.Mvc;
using System.Web.Security;

namespace TravelTrip.Controllers
{

    public class EntranceController : Controller
    {
        Context c = new Context();
        // GET: Entrance
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin name)
        {
            var info = c.Admins.FirstOrDefault(x => x.UserName == name.UserName && x.Password == name.Password); 
            if(info!=null)
            {
                FormsAuthentication.SetAuthCookie(info.UserName, false);
                Session["UserName"] = info.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Entrance");
        }
    }
}