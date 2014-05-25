using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Te.ActivityFinder.Core
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Activity", action = "Get", id = UrlParameter.Optional }
            );
        }
    }
}
