using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapQueenCMS.UI.Startup))]
namespace CapQueenCMS.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
