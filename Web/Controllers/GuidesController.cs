using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{   
    public class GuidesController : Controller
    {
        private WebContext context = new WebContext();


        //
        // GET: /Guides/

        public ViewResult Index()
        {
            return View(context.Guides.Include(guide => guide.Activities).Include(guide => guide.Author).ToList());
        }
        public ActionResult GuideBrowser()
        {
            return PartialView("Partials/GuideBrowser",context.Guides.Include(guide => guide.Activities).Include(guide => guide.Author).ToList());        
        }
       
        // GET: /Guides/
        public ActionResult GuideThumbnails(int id)
        {
            return PartialView("Partials/GuideThumbnails", context.Guides.Include(guide => guide.Activities).Where(x => x.GuideId == id).ToList());
        }
        public ActionResult GuideThumbnailPartial(Guide g)
        {
           // RenderPartial
            return PartialView("Partials/GuideThumbnailPartial", context.Guides.Include(guide => guide.Activities).Where(x=> x.GuideId == g.GuideId).ToList());
        }
        public ActionResult GuideThumbnailDetails(Guide g)
        {
            // RenderPartial
            return PartialView("Partials/GuideThumbnailDetails", context.Guides.Include(guide => guide.Activities).Where(x => x.GuideId == g.GuideId).ToList());
        }
     
        // GET: /Guides/Details/5

        public ViewResult Details(int id)
        {
            Guide guide = context.Guides.Single(x => x.GuideId == id);
            return View(guide);
        }

        //
        // GET: /Guides/Create

        public ActionResult Create()
        {
            ViewBag.PossibleAuthors = context.Users;
            return View();
        } 

        //
        // POST: /Guides/Create

        [HttpPost]
        public ActionResult Create(Guide guide)
        {
            if (ModelState.IsValid)
            {
                context.Guides.Add(guide);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleAuthors = context.Users;
            return View(guide);
        }
        
        //
        // GET: /Guides/Edit/5
 
        public ActionResult Edit(int id)
        {
            Guide guide = context.Guides.Single(x => x.GuideId == id);
            ViewBag.PossibleAuthors = context.Users;
            return View(guide);
        }

        //
        // POST: /Guides/Edit/5

        [HttpPost]
        public ActionResult Edit(Guide guide)
        {
            if (ModelState.IsValid)
            {
                context.Entry(guide).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleAuthors = context.Users;
            return View(guide);
        }

        //
        // GET: /Guides/Delete/5
 
        public ActionResult Delete(int id)
        {
            Guide guide = context.Guides.Single(x => x.GuideId == id);
            return View(guide);
        }

        //
        // POST: /Guides/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Guide guide = context.Guides.Single(x => x.GuideId == id);
            context.Guides.Remove(guide);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }

        // Custom Actions
        
        public ViewResult Description(int id)
        {
            Guide guide = context.Guides.Where(g => g.GuideId == id).FirstOrDefault();
            if (guide == null)
                RedirectToAction("index");

        	return View(guide);
        }
    }
}