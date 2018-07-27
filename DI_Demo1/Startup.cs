using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DI_Demo1.Startup))]
namespace DI_Demo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
