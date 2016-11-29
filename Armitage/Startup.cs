using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Armitage.Startup))]
namespace Armitage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
