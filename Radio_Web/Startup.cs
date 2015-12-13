using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Radio_Web.Startup))]
namespace Radio_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
