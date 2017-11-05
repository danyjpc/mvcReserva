using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcReservaHotel.Startup))]
namespace mvcReservaHotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
