using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MoviesRental
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "Customers",
               "Customers/Details/{id}",
               new { controller = "Customers", action = "Details", id = 1 }
            );


            routes.MapMvcAttributeRoutes(); //permite usar "ruteado" con atributos



            //routes.MapRoute(
            //   "MoviesByReleaseDate",
            //   "movies/released/{year}/{month}",
            //   new { controller = "Movies", action = "ByReleaseDate" },
            //   //new { year = @"\d{4}", month = @"\d{2}" }); años de 4 digitos y meses de 2
            //   new { year = @"2019|2020|2018", month = @"\d{2}" }); //solo puede ir los años listados


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
