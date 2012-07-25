namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dalchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReportsUIs", "Amount", c => c.Single(nullable: false));
            AlterColumn("dbo.ReportsUIs", "Wardnum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportsUIs", "Wardnum", c => c.String(maxLength: 4000));
            DropColumn("dbo.ReportsUIs", "Amount");
        }
    }
}
