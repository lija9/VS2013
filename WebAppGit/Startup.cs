using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppGit.Startup))]
namespace WebAppGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
