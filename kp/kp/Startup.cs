using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kp.Startup))]
namespace kp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
