using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapQueen.CMS.Startup))]
namespace CapQueen.CMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
