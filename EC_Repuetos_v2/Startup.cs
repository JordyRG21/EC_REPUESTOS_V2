using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EC_Repuetos_v2.Startup))]
namespace EC_Repuetos_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
