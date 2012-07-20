namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbload : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contributions", "ContributionType");
            DropColumn("dbo.Contributions", "ContributorType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contributions", "ContributorType", c => c.String(maxLength: 4000));
            AddColumn("dbo.Contributions", "ContributionType", c => c.String(maxLength: 4000));
        }
    }
}
