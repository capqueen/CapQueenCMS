using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapQueenCMS.Startup))]
namespace CapQueenCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
