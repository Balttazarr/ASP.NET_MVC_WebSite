using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CaledoniaYachtsWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           // routes.MapRoute(
            //    name: "LogoStart",                              
           //     url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index" }  

            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Model3D", id = UrlParameter.Optional }
            );
        }
    }
}
