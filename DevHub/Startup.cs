using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevHub.Startup))]
namespace DevHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
