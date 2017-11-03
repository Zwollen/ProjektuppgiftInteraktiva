using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektuppgiftInteraktiva.Startup))]
namespace ProjektuppgiftInteraktiva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
