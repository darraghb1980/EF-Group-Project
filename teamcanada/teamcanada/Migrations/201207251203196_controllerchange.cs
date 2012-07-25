namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class controllerchange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReportsUIs", "WardNum", c => c.Int(nullable: false));
            DropColumn("dbo.ReportsUIs", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReportsUIs", "Amount", c => c.Single(nullable: false));
            AlterColumn("dbo.ReportsUIs", "Wardnum", c => c.Int(nullable: false));
        }
    }
}
