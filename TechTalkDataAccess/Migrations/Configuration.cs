namespace TechTalkDataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTalkDataAccess.DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TechTalkDataAccess.DomainContext context)
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

            context.TechTalks.AddOrUpdate(
                new TechTalk{Description = "A demonstration of a simple Xamarin Application", Name = "Xamarin", LastModificationDateTime = DateTime.Now, Id = 1},
                new TechTalk{Description = "A review of Microsoft's TechEd", Name = "TechEd in a Nutshell", LastModificationDateTime = DateTime.Now, Id = 2});
        }
    }
}
