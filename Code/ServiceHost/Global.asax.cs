using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;
using Castle.Windsor;
using ServiceHost.App_Start;
using TigerFramework.Castle;
using UOM.Config.Castle;

namespace ServiceHost
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            WireUp();
        }

        private void WireUp()
        {
            var container = new WindsorContainer();
            TigerBootstrapper.WireUp(container,"DBConnection");
            UomBootstrapper.WireUp(container);

            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
                                new CastleControllerActivator(container));
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerSelector),
                            new CqrsControllerSelector(GlobalConfiguration.Configuration));
        }
    }
}
