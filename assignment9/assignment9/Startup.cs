using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment9.Startup))]
namespace assignment9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
