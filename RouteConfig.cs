using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Promona
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Process",
                url: "Process/{action}/{id}", 
                defaults: new { controller = "Process", action = "List", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //routes.MapRoute(
            //    name: "Test",
            //    url: "test/{action}",
            //    defaults: new { controller = "Test", action = "PrintMessage" }
            //);
            routes.MapRoute(
                name: "Mjesta",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Mjesta", action = "Gradovi", id = UrlParameter.Optional }
            );

        }
    }
}
