using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharityStartAtHome.Startup))]
namespace CharityStartAtHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
