using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiceHost
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            SetupCors(config);
            config.Filters.Add(new AuthorizeAttribute());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void SetupCors(HttpConfiguration config)
        {
            var allowedHosts = ConfigurationManager.AppSettings["AllowedHosts"];
            config.EnableCors(new EnableCorsAttribute(allowedHosts,"*","*"));
        }
    }
}
