using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // The empty route was moved to the Area responsible for the homepage (Assignment for now). This avoids the need to customize the view engine
            // http://stackoverflow.com/questions/2140208/how-to-set-a-default-route-to-an-area-in-mvc

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "MVC.Controllers" }
            );
        }
    }
}
