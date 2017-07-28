using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Add(new CustomJsonFormatter());
            config.MapHttpAttributeRoutes();
            config.Services.Replace(typeof(IAssembliesResolver), new ControllerResolver());
        }
    }
}
