using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBootcamp_Web.Startup))]
namespace MVCBootcamp_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
