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
            using (var context = new ContextoBD())
            {
                Universidade uni = new Universidade();
                uni.nome = "Uni1";
                context.universidades.Add(uni);
                context.SaveChanges();
            }
        }
    }
}
