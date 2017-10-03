using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using DependencyInjectionUnity.Contracts;
using DependencyInjectionUnity.Providers;

namespace DependencyInjectionUnity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IMyProvider, MyProvider>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}