using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HajjMangementSystem.Startup))]
namespace HajjMangementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
