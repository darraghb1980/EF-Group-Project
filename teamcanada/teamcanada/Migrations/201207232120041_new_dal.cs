namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_dal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GeneratedReports",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        NumVotes = c.Int(nullable: false),
                        Wardnum = c.String(maxLength: 4000),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
                        ContributionTypeDesc = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.ReportsUIs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ReportsUIs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        NumVotes = c.Int(nullable: false),
                        Wardnum = c.String(maxLength: 4000),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
                        ContributionTypeDesc = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.GeneratedReports");
        }
    }
}
