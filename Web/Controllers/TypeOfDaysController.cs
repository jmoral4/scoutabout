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
    public class TypeOfDaysController : Controller
    {
        private WebContext context = new WebContext();

        //
        // GET: /TypeOfDays/

        public ViewResult Index()
        {
            return View(context.TypeOfDays.Include(typeofday => typeofday.RelatedInterests).Include(typeofday => typeofday.RelatedTags).ToList());
        }

        //
        // GET: /TypeOfDays/Details/5

        public ViewResult Details(int id)
        {
            TypeOfDay typeofday = context.TypeOfDays.Single(x => x.TypeOfDayId == id);
            return View(typeofday);
        }

        //
        // GET: /TypeOfDays/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /TypeOfDays/Create

        [HttpPost]
        public ActionResult Create(TypeOfDay typeofday)
        {
            if (ModelState.IsValid)
            {
                context.TypeOfDays.Add(typeofday);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(typeofday);
        }
        
        //
        // GET: /TypeOfDays/Edit/5
 
        public ActionResult Edit(int id)
        {
            TypeOfDay typeofday = context.TypeOfDays.Single(x => x.TypeOfDayId == id);
            return View(typeofday);
        }

        //
        // POST: /TypeOfDays/Edit/5

        [HttpPost]
        public ActionResult Edit(TypeOfDay typeofday)
        {
            if (ModelState.IsValid)
            {
                context.Entry(typeofday).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeofday);
        }

        //
        // GET: /TypeOfDays/Delete/5
 
        public ActionResult Delete(int id)
        {
            TypeOfDay typeofday = context.TypeOfDays.Single(x => x.TypeOfDayId == id);
            return View(typeofday);
        }

        //
        // POST: /TypeOfDays/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeOfDay typeofday = context.TypeOfDays.Single(x => x.TypeOfDayId == id);
            context.TypeOfDays.Remove(typeofday);
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