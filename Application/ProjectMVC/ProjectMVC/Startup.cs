using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectMVC.Startup))]
namespace ProjectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
