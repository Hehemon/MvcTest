using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcProjectManagementTest.Startup))]
namespace MvcProjectManagementTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
