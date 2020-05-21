using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ListaVendas.Startup))]
namespace ListaVendas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
