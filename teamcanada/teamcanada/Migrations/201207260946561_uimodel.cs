namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uimodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReportsUIs", "Amount", c => c.Single(nullable: false));
            AddColumn("dbo.ReportsUIs", "TotalAmount", c => c.Single(nullable: false));
            AlterColumn("dbo.ReportsUIs", "WardNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportsUIs", "Wardnum", c => c.String(maxLength: 4000));
            DropColumn("dbo.ReportsUIs", "TotalAmount");
            DropColumn("dbo.ReportsUIs", "Amount");
        }
    }
}
