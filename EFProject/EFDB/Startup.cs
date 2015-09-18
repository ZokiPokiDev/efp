using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFDB.Startup))]
namespace EFDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
