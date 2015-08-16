using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace TrabalhoASW.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //public virtual Pessoa Pessoa { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //public DbSet<Pessoa> pessoas { get; set; }

        public ApplicationDbContext()
            : base("Server=.\\SQLEXPRESS;           Database=BDASW;           Trusted_Connection=yes;", throwIfV1Schema: false)
        {
        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Pessoa>()
                   .HasOptional(p => p.usuario).WithOptionalPrincipal(u => u.Pessoa)
                   .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }*/
        public static ApplicationDbContext Create()
        {
           
            return new ApplicationDbContext();
        }
    }
}