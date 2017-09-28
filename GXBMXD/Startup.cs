using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GXBMXD.Startup))]
namespace GXBMXD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
