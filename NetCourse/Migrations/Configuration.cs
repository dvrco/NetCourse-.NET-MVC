namespace NetCourse.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NetCourse.NewFolder1.NetCourseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NetCourse.NewFolder1.NetCourseDbContext context)
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

            context.Pages.AddOrUpdate(p => p.Name,
                new Page { Name = "About Us", Description = "Lorem ipsum.." },
                new Page { Name = "About Company", Description = "Ipsum lorem.." });

            context.Courses.AddOrUpdate(p => p.Name,
                new Course { Name = "C# Course", Description = "Lorem Ipsum..", CreatedAt = DateTime.UtcNow, ModifiedAt = DateTime.UtcNow },
                new Course { Name = "Java Course", Description = "Lorem Ipsum..", CreatedAt = DateTime.UtcNow, ModifiedAt = DateTime.UtcNow },
                new Course { Name = "C++ Course", Description = "Lorem Ipsum..", CreatedAt = DateTime.UtcNow, ModifiedAt = DateTime.UtcNow }
                );
        }
    }
}
