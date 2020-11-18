using System.Web.Mvc;
using System.Web.Routing;

namespace HandleErrorsINMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalFilters.Filters.Add(new HandleErrorAttribute() { View = "CustomError" } );  //It will work for versatile controllers and we don't have to need to write [HandleError] everywhere, this is global
        }
    }
}
