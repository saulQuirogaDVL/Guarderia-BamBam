using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proyecto
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Recuerdos", "Recuerdos/{Action}/{id}",
                defaults: new
                {
                    Controller = "Recuerdos",
                    Action = "Inicio",
                    id = UrlParameter.Optional
                });

            routes.MapRoute(
                "Actividades", "Actividades/{Action}/{id}",
                defaults: new
                {
                    Controller = "Actividades",
                    Action = "Inicio",
                    id = UrlParameter.Optional
                });
            routes.MapRoute(
                "Informes", "Informes/{Action}/{id}",
                defaults: new
                {
                    Controller = "Informes",
                    Action = "Inicio",
                    id = UrlParameter.Optional
                });
            routes.MapRoute(
                "Teofrece", "Teofrece/{Action}/{id}",
                defaults: new
                {
                    Controller = "Teofrece",
                    Action = "Inicio",
                    id = UrlParameter.Optional
                });
            routes.MapRoute(
               "Ubicacion", "Ubicacion/{Action}/{id}",
               defaults: new
               {
                   Controller = "Ubicacion",
                   Action = "Inicio",
                   id = UrlParameter.Optional
               });

            routes.MapRoute(
              "Login", "Login/{Action}/{id}",
              defaults: new
              {
                  Controller = "Login",
                  Action = "Inicio",
                  id = UrlParameter.Optional
              });
        }
    }
}
