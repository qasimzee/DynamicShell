using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewHome.Startup))]
namespace NewHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
