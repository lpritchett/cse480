using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cse480.Startup))]
namespace cse480
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
