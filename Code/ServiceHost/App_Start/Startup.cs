using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Windsor;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;
using ProductManagment.Config.Castle;
using TigerFramework.Castle;
using UOM.Config.Castle;

[assembly: OwinStartup(typeof(ServiceHost.App_Start.Startup))]
namespace ServiceHost.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            SetupAccessTokenValidation(app);
            WireUp(config);
            app.UseWebApi(config);
        }
        private void WireUp(HttpConfiguration config)
        {
            var container = new WindsorContainer();
            TigerBootstrapper.WireUp(container, "DBConnection");
            UomBootstrapper.WireUp(container);
            ProductManagementBootstrapper.WireUp(container);

            config.Services.Replace(typeof(IHttpControllerActivator),new CastleControllerActivator(container));
            config.Services.Replace(typeof(IHttpControllerSelector),new CqrsControllerSelector(config));
        }

        private void SetupAccessTokenValidation(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "http://localhost:5000",
            });
        }

    }
}
