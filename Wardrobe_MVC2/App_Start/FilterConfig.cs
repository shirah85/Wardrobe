﻿using System.Web;
using System.Web.Mvc;

namespace Wardrobe_MVC2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
