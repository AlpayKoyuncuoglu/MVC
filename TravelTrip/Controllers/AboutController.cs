using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        Context ctx = new Context();

        // GET: About 
        public ActionResult Index()
        {
            var values = ctx.AboutUs.ToList();
            return View(values);
        }
    }
}