using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesRental.Startup))]
namespace MoviesRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
