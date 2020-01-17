using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyASP.Startup))]
namespace VidlyASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
