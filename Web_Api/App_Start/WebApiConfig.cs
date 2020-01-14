using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Web_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "MaRoute",
               routeTemplate: "api/{controller}/{action}/{year}/{month}/{day}",
               defaults: new {  
                   month = RouteParameter.Optional,
                   day = RouteParameter.Optional,
                   year = RouteParameter.Optional
               },
               constraints: new
               {
                   month = @"\d{0,2}",
                   day = @"\d{0,2}",
                   year = @"\d{0,4}"
               }
           );
        }
    }
}
