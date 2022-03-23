using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarParkingApp.Startup))]
namespace CarParkingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
