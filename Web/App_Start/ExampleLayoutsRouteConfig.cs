using System.Web.Routing;
using NavigationRoutes;
using Web.Controllers;

namespace Web
{
  public class ExampleLayoutsRouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.MapNavigationRoute<HomeController>("Home", c => c.Index());
      routes.MapNavigationRoute<HomeController>("About", c => c.About());

    }
  }
}