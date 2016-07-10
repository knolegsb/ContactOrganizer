using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactOrganizer.Startup))]
namespace ContactOrganizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
