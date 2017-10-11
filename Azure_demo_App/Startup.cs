using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azure_demo_App.Startup))]
namespace Azure_demo_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
