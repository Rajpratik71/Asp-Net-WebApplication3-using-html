using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp_Net_WebApplication3_using_html.Startup))]
namespace Asp_Net_WebApplication3_using_html
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
