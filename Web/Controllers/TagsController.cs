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
    public class TagsController : Controller
    {
        private WebContext context = new WebContext();

        //
        // GET: /Tags/

        public ViewResult Index()
        {
            return View(context.Tags.ToList());
        }

        //
        // GET: /Tags/Details/5

        public ViewResult Details(int id)
        {
            Tag tag = context.Tags.Single(x => x.TagId == id);
            return View(tag);
        }

        //
        // GET: /Tags/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Tags/Create

        [HttpPost]
        public ActionResult Create(Tag tag)
        {
            if (ModelState.IsValid)
            {
                context.Tags.Add(tag);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(tag);
        }
        
        //
        // GET: /Tags/Edit/5
 
        public ActionResult Edit(int id)
        {
            Tag tag = context.Tags.Single(x => x.TagId == id);
            return View(tag);
        }

        //
        // POST: /Tags/Edit/5

        [HttpPost]
        public ActionResult Edit(Tag tag)
        {
            if (ModelState.IsValid)
            {
                context.Entry(tag).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tag);
        }

        //
        // GET: /Tags/Delete/5
 
        public ActionResult Delete(int id)
        {
            Tag tag = context.Tags.Single(x => x.TagId == id);
            return View(tag);
        }

        //
        // POST: /Tags/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Tag tag = context.Tags.Single(x => x.TagId == id);
            context.Tags.Remove(tag);
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