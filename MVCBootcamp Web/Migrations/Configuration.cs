namespace MVCBootcamp_Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using DAL;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<MVCBootcamp_Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //ContextKey = "MVCBootcamp_Web.Models.ApplicationDbContext";
        }

        protected override void Seed(MVCBootcamp_Web.Models.ApplicationDbContext context)
        {
            if (!context.Users.Any(u => u.UserName == "admin1")) {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                var user = new ApplicationUser { UserName = "admin1" };
                userManager.Create(user, "123456");
                roleManager.Create(new IdentityRole { Name = "Administrators" });
                userManager.AddToRole(user.Id, "Administrators");
            }

            if (!context.Users.Any(u => u.UserName == "user1")) {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                var user = new ApplicationUser { UserName = "user1" };
                userManager.Create(user, "123456");
                roleManager.Create(new IdentityRole { Name = "Members" });
                userManager.AddToRole(user.Id, "Members");
            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
