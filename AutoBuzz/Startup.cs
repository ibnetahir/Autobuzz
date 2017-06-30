using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoBuzz.Startup))]
namespace AutoBuzz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
