using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
  public class HomeController : BootstrapBaseController
  {

    public ActionResult Index()
    {
      ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

      return View( ComboBoxItems.Cities );
    }

    public ActionResult BestDays()
    {
      ViewBag.Message = "Best days.";

      return View();
    }

    public ActionResult Cities()
    {
      ViewBag.Message = "Cities.";

      return View();
    }

    public ActionResult TopLocal()
    {
      ViewBag.Message = "Top Local.";

      return View();
    }

    public ActionResult MyGuides()
    {
      ViewBag.Message = "My Guides.";

      return View();
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
