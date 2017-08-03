namespace Venme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTransactionColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "fromUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "toUserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "amount", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "from");
            DropColumn("dbo.Transactions", "to");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "to", c => c.Int());
            AddColumn("dbo.Transactions", "from", c => c.Int());
            AlterColumn("dbo.Transactions", "amount", c => c.Int());
            DropColumn("dbo.Transactions", "toUserId");
            DropColumn("dbo.Transactions", "fromUserId");
        }
    }
}
