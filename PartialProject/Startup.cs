using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialProject.Startup))]
namespace PartialProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
