namespace MvcProjectManagementTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Performer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductTasks", "Performer_Id", c => c.Int());
            CreateIndex("dbo.ProductTasks", "Performer_Id");
            AddForeignKey("dbo.ProductTasks", "Performer_Id", "dbo.Performers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTasks", "Performer_Id", "dbo.Performers");
            DropIndex("dbo.ProductTasks", new[] { "Performer_Id" });
            DropColumn("dbo.ProductTasks", "Performer_Id");
        }
    }
}
