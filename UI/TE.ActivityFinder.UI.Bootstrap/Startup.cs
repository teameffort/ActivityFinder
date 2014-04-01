using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TE.ActivityFinder.UI.Bootstrap.Startup))]
namespace TE.ActivityFinder.UI.Bootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
