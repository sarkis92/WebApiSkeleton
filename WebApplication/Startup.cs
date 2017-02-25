using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Practices.Unity.WebApi;
using Owin;
using WebApplication;
using WebApplication.App_Start;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration
            {
                DependencyResolver = new UnityHierarchicalDependencyResolver(UnityConfig.GetConfiguredContainer())
            };

            ConfigureRoutes(config);
            app.UseWebApi(config);
        }


        public void ConfigureRoutes(HttpConfiguration httpConfig)
        {
            httpConfig.MapHttpAttributeRoutes();

            httpConfig.Routes.MapHttpRoute("default", "api/{controller}/{id}",
                new { controller = "Values", id = RouteParameter.Optional });
        }
    }
}
