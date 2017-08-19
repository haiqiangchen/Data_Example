using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DataBase_example
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            new Models.SqlInit();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
