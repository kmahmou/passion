using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DefaultApplication.Startup))]
namespace DefaultApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
