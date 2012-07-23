namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration23Jul : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Report5UI", "ContributionTypeDesc", c => c.String(maxLength: 4000));
            DropColumn("dbo.Report5UI", "ContributionType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Report5UI", "ContributionType", c => c.String(maxLength: 4000));
            DropColumn("dbo.Report5UI", "ContributionTypeDesc");
        }
    }
}
