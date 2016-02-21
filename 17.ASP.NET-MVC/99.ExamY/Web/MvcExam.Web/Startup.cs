using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(MvcExam.Web.Startup))]

namespace MvcExam.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
