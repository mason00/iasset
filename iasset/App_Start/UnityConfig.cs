using DataService;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace iasset
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IGateManageService, GateManageService>();
            container.RegisterType<IFlightRepo, FlightRepository>();
            container.RegisterType<IGateRepo, GateRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}