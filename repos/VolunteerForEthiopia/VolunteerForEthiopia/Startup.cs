using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VolunteerForEthiopia.Startup))]
namespace VolunteerForEthiopia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
