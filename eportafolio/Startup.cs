using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eportafolio.Startup))]
namespace eportafolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
