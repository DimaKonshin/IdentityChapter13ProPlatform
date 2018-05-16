using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Users.Models;

namespace Users.Infrastructure
{
    public class AppIndentityDbContext:IdentityDbContext<AppUser>
    {
        public AppIndentityDbContext():base("IdentityDb")
        {

        }

        static AppIndentityDbContext()
        {
            Database.SetInitializer<AppIndentityDbContext>(new IdentityDbInit());
        }
    }

    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<AppIndentityDbContext>
    {
        protected override void Seed(AppIndentityDbContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }

        public void PerformInitialSetup(AppIndentityDbContext context)
        {
            
        }
    }
}