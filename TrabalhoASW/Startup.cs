using Microsoft.Owin;
using Owin;
using TrabalhoASW.Models;

[assembly: OwinStartupAttribute(typeof(TrabalhoASW.Startup))]
namespace TrabalhoASW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
