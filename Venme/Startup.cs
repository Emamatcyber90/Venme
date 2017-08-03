using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Venme.Startup))]
namespace Venme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
