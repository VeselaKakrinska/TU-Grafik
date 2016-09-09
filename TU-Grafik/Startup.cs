using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TU_Grafik.Startup))]
namespace TU_Grafik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
