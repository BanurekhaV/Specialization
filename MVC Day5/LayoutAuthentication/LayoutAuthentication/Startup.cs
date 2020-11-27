using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LayoutAuthentication.Startup))]
namespace LayoutAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
