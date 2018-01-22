using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoGames.Startup))]
namespace GoGames
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
