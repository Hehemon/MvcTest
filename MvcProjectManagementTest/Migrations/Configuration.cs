using MvcProjectManagementTest.Models;

namespace MvcProjectManagementTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcProjectManagementTest.Models.TaskManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcProjectManagementTest.Models.TaskManagerDbContext";
        }

        protected override void Seed(MvcProjectManagementTest.Models.TaskManagerDbContext context)
        {
            context.Performers.AddOrUpdate(i => i.Surname,
                new Performer
                {
                    Surname =  "Ivanonov",
                    Name = "Ivan",
                    MiddleName = "Ivanovich",
                },
                new Performer
                {
                    Surname = "Vasechkin",
                    Name = "Petka",
                    MiddleName = "Petrovich",
                },
                new Performer
                {
                    
                });

            context.Tasks.AddOrUpdate(i => i.Name,
                new ProductTask
                {
                    Name = "First",
                    EndTime = DateTime.Parse("2015-12-12"),
                    StartTime = DateTime.Parse("2015-10-12"),
                    PlannedTime = new TimeSpan(2,2,2),
                    Status = TaskStatus.NotStarted,
                },
                new ProductTask
                {
                    Name = "Second",
                    EndTime = DateTime.Parse("2015-10-10"),StartTime = DateTime.Parse("2015-8-8"),
                    PlannedTime = new TimeSpan(0, 3, 3),
                    Status = TaskStatus.NotStarted,
                });

        }
    }
}
