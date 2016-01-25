using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.MVC.Startup))]
namespace _02.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
