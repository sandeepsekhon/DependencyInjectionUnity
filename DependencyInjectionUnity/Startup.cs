using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependencyInjectionUnity.Startup))]
namespace DependencyInjectionUnity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
