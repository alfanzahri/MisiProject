using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectGit.Startup))]
namespace ProjectGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
