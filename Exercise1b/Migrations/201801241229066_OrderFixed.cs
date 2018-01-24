namespace Exercise1b.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderFixed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderedOn = c.DateTime(nullable: false),
                        DeliveredOn = c.DateTime(nullable: false),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
