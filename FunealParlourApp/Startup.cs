using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunealParlourApp.Startup))]
namespace FunealParlourApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
