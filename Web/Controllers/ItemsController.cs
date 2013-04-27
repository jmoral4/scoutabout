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
    public class ItemsController : Controller
    {
        private WebContext context = new WebContext();

        //
        // GET: /Items/

        public ViewResult Index()
        {
            return View(context.Items.ToList());
        }

        //
        // GET: /Items/Details/5

        public ViewResult Details(int id)
        {
            Item item = context.Items.Single(x => x.ItemId == id);
            return View(item);
        }

        //
        // GET: /Items/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Items/Create

        [HttpPost]
        public ActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                context.Items.Add(item);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(item);
        }
        
        //
        // GET: /Items/Edit/5
 
        public ActionResult Edit(int id)
        {
            Item item = context.Items.Single(x => x.ItemId == id);
            return View(item);
        }

        //
        // POST: /Items/Edit/5

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        //
        // GET: /Items/Delete/5
 
        public ActionResult Delete(int id)
        {
            Item item = context.Items.Single(x => x.ItemId == id);
            return View(item);
        }

        //
        // POST: /Items/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = context.Items.Single(x => x.ItemId == id);
            context.Items.Remove(item);
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