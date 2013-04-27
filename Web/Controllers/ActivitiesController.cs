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
    public class ActivitiesController : Controller
    {
        private WebContext context = new WebContext();

        //
        // GET: /Activities/

        public ViewResult Index()
        {
            return View(context.Activities.Include(activity => activity.Tags).Include(activity => activity.Interests).ToList());
        }

        //
        // GET: /Activities/Details/5

        public ViewResult Details(int id)
        {
            Activity activity = context.Activities.Single(x => x.ActivityId == id);
            return View(activity);
        }

        //
        // GET: /Activities/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Activities/Create

        [HttpPost]
        public ActionResult Create(Activity activity)
        {
            if (ModelState.IsValid)
            {
                context.Activities.Add(activity);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(activity);
        }
        
        //
        // GET: /Activities/Edit/5
 
        public ActionResult Edit(int id)
        {
            Activity activity = context.Activities.Single(x => x.ActivityId == id);
            return View(activity);
        }

        //
        // POST: /Activities/Edit/5

        [HttpPost]
        public ActionResult Edit(Activity activity)
        {
            if (ModelState.IsValid)
            {
                context.Entry(activity).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activity);
        }

        //
        // GET: /Activities/Delete/5
 
        public ActionResult Delete(int id)
        {
            Activity activity = context.Activities.Single(x => x.ActivityId == id);
            return View(activity);
        }

        //
        // POST: /Activities/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Activity activity = context.Activities.Single(x => x.ActivityId == id);
            context.Activities.Remove(activity);
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