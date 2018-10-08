using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneBookDb.Startup))]
namespace PhoneBookDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
