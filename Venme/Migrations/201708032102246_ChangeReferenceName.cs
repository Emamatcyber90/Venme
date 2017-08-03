namespace Venme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeReferenceName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transactions", "FromUserId");
            RenameColumn(table: "dbo.Transactions", name: "UserId", newName: "FromUserId");
            RenameIndex(table: "dbo.Transactions", name: "IX_UserId", newName: "IX_FromUserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Transactions", name: "IX_FromUserId", newName: "IX_UserId");
            RenameColumn(table: "dbo.Transactions", name: "FromUserId", newName: "UserId");
            AddColumn("dbo.Transactions", "FromUserId", c => c.Int(nullable: false));
        }
    }
}
