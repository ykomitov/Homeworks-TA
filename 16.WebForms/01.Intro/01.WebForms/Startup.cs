using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.WebForms.Startup))]
namespace _01.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
