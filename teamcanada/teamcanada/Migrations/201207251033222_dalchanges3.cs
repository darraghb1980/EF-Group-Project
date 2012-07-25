namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dalchanges3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReportsUIs", "Wardnum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportsUIs", "WardNum", c => c.Int(nullable: false));
        }
    }
}
