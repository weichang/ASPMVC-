using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc07.Startup))]
namespace mvc07
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
