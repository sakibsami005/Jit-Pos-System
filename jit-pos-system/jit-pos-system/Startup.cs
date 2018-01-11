using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jit_pos_system.Startup))]
namespace jit_pos_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
