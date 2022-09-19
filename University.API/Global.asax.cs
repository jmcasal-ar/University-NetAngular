using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using University.BL.DTOs;

namespace University.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //CREAMOs propiedad interna estatica
        internal static MapperConfiguration MapperConfiguration { get; set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Cuando la aplicación se esté ejecutando
            //AutoMapper, para que este funcionando nuestro controlador funcione nuestra aplicacion
            //a través de este mapper configuration
            MapperConfiguration = MapperConfig.MapperConfiguration();
        }
    }
}
