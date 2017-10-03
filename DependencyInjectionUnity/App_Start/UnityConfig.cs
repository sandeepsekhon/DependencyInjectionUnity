using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using DependencyInjectionUnity.Contracts;
using DependencyInjectionUnity.Providers;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using DependencyInjectionUnity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web;

namespace DependencyInjectionUnity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IMyProvider, MyProvider>();
            var accountInjectionConstructor = new InjectionConstructor(new ApplicationDbContext());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(accountInjectionConstructor);
            container.RegisterType<IRoleStore<IdentityRole, string>, RoleStore<IdentityRole>>(accountInjectionConstructor);
            container.RegisterType<IAuthenticationManager>(new InjectionFactory(o => System.Web.HttpContext.Current.GetOwinContext().Authentication));
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}