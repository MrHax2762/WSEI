using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{parametr}",
                defaults: new { controller = "Kontroler", action = "Domyslny", parametr = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Widok",
                url: "{controller}/{action}/{parametr}",
                defaults: new { controller = "Kontroler", action = "Widok", parametr = UrlParameter.Optional }
            );
         
        }
    }
}