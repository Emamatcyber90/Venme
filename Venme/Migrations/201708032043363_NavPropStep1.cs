namespace Venme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NavPropStep1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "UserId", c => c.Int());
            Sql(@"UPDATE dbo.Transactions SET UserId = 1000 WHERE UserId IS NULL");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "UserId");
        }
    }
}
