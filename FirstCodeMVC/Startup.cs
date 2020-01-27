using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstCodeMVC.Startup))]
namespace FirstCodeMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
