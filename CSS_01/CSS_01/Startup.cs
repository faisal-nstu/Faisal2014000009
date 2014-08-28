using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSS_01.Startup))]
namespace CSS_01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
