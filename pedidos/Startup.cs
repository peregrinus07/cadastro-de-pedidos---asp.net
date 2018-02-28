using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pedidos.Startup))]
namespace pedidos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
