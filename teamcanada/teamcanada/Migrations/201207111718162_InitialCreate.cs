namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(),
                        ElectionYear = c.Int(nullable: false),
                        WardNum = c.Int(nullable: false),
                        NumVotes = c.Int(nullable: false),
                        CandidateLastName = c.String(),
                        CandidateFirstName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Contributions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(),
                        ElectionYear = c.Int(nullable: false),
                        ContributorFirstName = c.String(),
                        ContributorLastName = c.String(),
                        ContributorPostCode = c.String(),
                        ContributorAddress = c.String(),
                        WardNum = c.Int(nullable: false),
                        Amount = c.Single(nullable: false),
                        ContributionType = c.String(),
                        ContributionTypeDesc = c.String(),
                        ContributorType = c.String(),
                        ContributorTypeDesc = c.String(),
                        CandidateFirstName = c.String(),
                        CandidateLastName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contributions");
            DropTable("dbo.Results");
        }
    }
}
