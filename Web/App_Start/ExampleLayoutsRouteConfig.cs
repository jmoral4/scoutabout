﻿using System.Web.Routing;
using NavigationRoutes;
using Web.Controllers;

namespace Web
{
  public class ExampleLayoutsRouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.MapNavigationRoute<HomeController>("Best Days", c => c.BestDays());
      routes.MapNavigationRoute<HomeController>("Cities", c => c.Cities());
      routes.MapNavigationRoute<HomeController>("Mobile", c => c.TopLocal());
      routes.MapNavigationRoute<HomeController>("My Guides", c => c.MyGuides());

    }
  }
}