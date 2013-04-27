using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

      return View();
    }


    public ActionResult GuidesByCity(string SelectedCity)
    {
        IEnumerable<Guide> guides = SearchForGuidesBy(SelectedCity);
        return View(guides);
    }

    private IEnumerable<Guide> SearchForGuidesBy(string City)
    {
       
        return new List<Guide>().DefaultIfEmpty();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your app description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}
