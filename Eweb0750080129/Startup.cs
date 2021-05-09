using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eweb0750080129.Startup))]
namespace Eweb0750080129
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
