namespace Soding.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Soding.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Soding.Models.SodingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Soding.Models.SodingContext";
        }

        protected override void Seed(Soding.Models.SodingContext context)
        {
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
            context.Users.AddOrUpdate(u => u.Id,
                new User() { Name = "Ahmad Tarmizi Bin Jauhari", Email = "ahmad.tarmizi@soding.com"},
                new User() { Name = "Siew Kai Ming", Email = "kai.ming@soding.com"},
                new User() { Name = "Ravi Rajnikan", Email = "ravi@soding.com"}
                );
            context.SaveChanges();
            context.Tasks.AddOrUpdate(t=>t.Id,
                new Task() { Name = "Task 1 - Testing", Description="This is Example for task 1", UserId = context.Users.SingleOrDefault(u=>u.Name == "Siew Kai Ming").Id, DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                new Task() { Name = "Task 2 - Testing", Description = "This is Example for task 2", UserId = context.Users.SingleOrDefault(u => u.Name == "Ravi Rajnikan").Id, DateCreated = DateTime.Now, DateUpdated = DateTime.Now }
                );
        }
    }
}
