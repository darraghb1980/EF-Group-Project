namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dalchanges2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReportsUIs", "WardNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportsUIs", "Wardnum", c => c.Int(nullable: false));
        }
    }
}
