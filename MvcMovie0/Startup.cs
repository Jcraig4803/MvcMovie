using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMovie0.Startup))]
namespace MvcMovie0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
