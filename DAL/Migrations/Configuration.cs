namespace DAL.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.AssignmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.AssignmentContext context)
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
            context.BulletPoints.AddOrUpdate(
                p => p.Point,
                new BulletPoint { Point = "Overall: Solution created from Empty template to guaranteed that only used code is maintained." },
                new BulletPoint { Point = "Overall: Front-end kept minimal to meet the requirements." },
                new BulletPoint { Point = "Overall: Applied maintainability concepts to back-end (production-ready code)." },
                new BulletPoint { Point = "CTA: Generates from an action allowing dynamic content based on profile and statistics gathering." },
                new BulletPoint { Point = "CTA: Link for CTA button could be a redirected from an action to record the successful user's interaction." },
                new BulletPoint { Point = "Bullet Point List: Annotation used on model (DisplayName)." },
                new BulletPoint { Point = "Bullet Point List: Generates from Action as a reusable component." },
                new BulletPoint { Point = "Bullet Point List: Uses DisplayTemplates to make it even more reusable." },
                new BulletPoint { Point = "Bullet Point List: Uses OutputCache (refreshing every 3600s) as this component just change." },
                new BulletPoint { Point = "Bullet Point List: Initially developed as a mocked service, then migrate to EntityFramework." }
                );
        }
    }
}
