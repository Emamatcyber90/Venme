namespace Venme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NavPropStep2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "UserId");
            AddForeignKey("dbo.Transactions", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "UserId", "dbo.Users");
            DropIndex("dbo.Transactions", new[] { "UserId" });
            AlterColumn("dbo.Transactions", "UserId", c => c.Int());
        }
    }
}
