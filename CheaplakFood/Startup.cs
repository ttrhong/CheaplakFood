using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheaplakFood.Startup))]
namespace CheaplakFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
