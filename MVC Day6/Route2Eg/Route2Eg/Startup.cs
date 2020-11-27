using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Route2Eg.Startup))]
namespace Route2Eg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
