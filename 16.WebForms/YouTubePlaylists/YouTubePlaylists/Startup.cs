using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouTubePlaylists.Startup))]
namespace YouTubePlaylists
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
