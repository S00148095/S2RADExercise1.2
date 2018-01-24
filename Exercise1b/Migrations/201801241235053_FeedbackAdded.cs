namespace Exercise1b.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FeedbackAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "FeedbackRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "FeedbackRating");
        }
    }
}
