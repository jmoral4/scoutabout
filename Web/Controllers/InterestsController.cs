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
    public class InterestsController : Controller
    {
        private WebContext context = new WebContext();

        //
        // GET: /Interests/

        public ViewResult Index()
        {
            return View(context.Interests.Include(interest => interest.RelatedTags).ToList());
        }

        //
        // GET: /Interests/Details/5

        public ViewResult Details(int id)
        {
            Interest interest = context.Interests.Single(x => x.InterestId == id);
            return View(interest);
        }

        //
        // GET: /Interests/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Interests/Create

        [HttpPost]
        public ActionResult Create(Interest interest)
        {
            if (ModelState.IsValid)
            {
                context.Interests.Add(interest);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(interest);
        }
        
        //
        // GET: /Interests/Edit/5
 
        public ActionResult Edit(int id)
        {
            Interest interest = context.Interests.Single(x => x.InterestId == id);
            return View(interest);
        }

        //
        // POST: /Interests/Edit/5

        [HttpPost]
        public ActionResult Edit(Interest interest)
        {
            if (ModelState.IsValid)
            {
                context.Entry(interest).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interest);
        }

        //
        // GET: /Interests/Delete/5
 
        public ActionResult Delete(int id)
        {
            Interest interest = context.Interests.Single(x => x.InterestId == id);
            return View(interest);
        }

        //
        // POST: /Interests/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Interest interest = context.Interests.Single(x => x.InterestId == id);
            context.Interests.Remove(interest);
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
    }
}