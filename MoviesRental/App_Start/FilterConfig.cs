﻿using System.Web;
using System.Web.Mvc;

namespace MoviesRental
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute()); //pide login en todo el sitio
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
