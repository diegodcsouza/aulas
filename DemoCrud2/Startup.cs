using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoCrud2.Startup))]
namespace DemoCrud2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
