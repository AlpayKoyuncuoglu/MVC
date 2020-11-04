using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        [Authorize]

        // GET: Admin
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog x)
        {
            c.Blogs.Add(x);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult TakeBlog(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("TakeBlog", bl);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Explanation = b.Explanation;
            blg.Title = b.Title;
            blg.BlogImage = b.BlogImage; 
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult CommentList()
        {
            var comments=c.Comments.ToList();
            return View(comments);
        }
        public ActionResult DeleteComment(int id)
        {
            var b = c.Comments.Find(id);
            c.Comments.Remove(b);
            c.SaveChanges();
            return RedirectToAction("CommentList");

        }
        public ActionResult TakeComment(int id)
        {
            var cmmnt = c.Comments.Find(id);
            return View("TakeComment",cmmnt);
        }
        public ActionResult UpdateComment(Comments cmmnt)
        {
            var cmmnts = c.Comments.Find(cmmnt.ID);
            cmmnts.Username = cmmnt.Username;
            cmmnts.Mail = cmmnt.Mail;
            cmmnts.Comment= cmmnt.Comment;
            c.SaveChanges();
            return RedirectToAction("CommentList");

        }
    }
}