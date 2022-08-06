using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eProject3_NGO_Website.Startup))]
namespace eProject3_NGO_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
