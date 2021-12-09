using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySpaza.WebUI.Startup))]
namespace MySpaza.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
