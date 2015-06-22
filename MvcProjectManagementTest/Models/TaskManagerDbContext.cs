using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProjectManagementTest.Models
{
    public class TaskManagerDbContext : DbContext
    {
        public DbSet<Performer> Performers { get; set; }
        public DbSet<ProductTask> Tasks { get; set; }
    }
}