using System.Web.Http;
using Owin;

namespace SelfHostOwin
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
           // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "Devices",
                routeTemplate: "api/{controller}/{id}",
                new { controller = "devices", id = RouteParameter.Optional }
            );
            appBuilder.UseWebApi(config);
        }
    }
}