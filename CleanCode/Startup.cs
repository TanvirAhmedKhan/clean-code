using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CleanCode.Startup))]
namespace CleanCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
