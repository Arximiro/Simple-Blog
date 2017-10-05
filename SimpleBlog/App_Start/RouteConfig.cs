using SimpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(PostsController).Namespace };  // This allows us to specify the namespace so that we can identify controllers
                                                                           // that share the same name within our routes.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("TagForRealThisTime", "tag/{idAndSlug}", new { controller = "Posts", action = "Tag" }, namespaces);
            routes.MapRoute("Tag", "tag/{id}-{slug}", new { controller = "Posts", action = "Tag" }, namespaces);

            routes.MapRoute("PostForRealThisTime", "post/{idAndSlug}", new { controller = "Posts", action = "Show" }, namespaces);
            routes.MapRoute("Post", "post/{id}-{slug}", new { controller = "Posts", action = "Show" }, namespaces);

            routes.MapRoute("Home", "", new { Controller = "Posts", action = "Index" }, namespaces);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}