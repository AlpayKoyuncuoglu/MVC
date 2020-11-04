using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        // GET: Guide
        BlogComment bc = new BlogComment();

        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            bc.Value1 = c.Blogs.ToList();
            bc.Value3 = c.Blogs.Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        {

            //var blogFind = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Value1 = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Value2 = c.Comments.Where(x => x.Blogid == id).ToList();

            return View(bc);
        }

        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Comment(Comments b)
        {
            c.Comments.Add(b);
            c.SaveChanges();
            return PartialView();
        }
        

    }
}