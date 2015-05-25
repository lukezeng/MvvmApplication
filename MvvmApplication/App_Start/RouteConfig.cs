using System.Web.Mvc;
using System.Web.Routing;

namespace MvvmApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Ad", "{controller}/{relationId}",
                new { controller = "Ad", action = "Index", relationId = 1 }
                );

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}