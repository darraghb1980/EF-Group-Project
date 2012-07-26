namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReportsUIs", "ContributorLastName", c => c.String(maxLength: 4000));
            AddColumn("dbo.ReportsUIs", "ContributorFirstName", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReportsUIs", "ContributorFirstName");
            DropColumn("dbo.ReportsUIs", "ContributorLastName");
        }
    }
}
