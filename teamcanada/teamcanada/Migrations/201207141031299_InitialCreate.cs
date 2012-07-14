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
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        WardNum = c.Int(nullable: false),
                        NumVotes = c.Int(nullable: false),
                        CandidateLastName = c.String(maxLength: 4000),
                        CandidateFirstName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Contributions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        ContributorFirstName = c.String(maxLength: 4000),
                        ContributorLastName = c.String(maxLength: 4000),
                        ContributorPostCode = c.String(maxLength: 4000),
                        ContributorAddress = c.String(maxLength: 4000),
                        WardNum = c.Int(nullable: false),
                        Amount = c.Single(nullable: false),
                        ContributionType = c.String(maxLength: 4000),
                        ContributionTypeDesc = c.String(maxLength: 4000),
                        ContributorType = c.String(maxLength: 4000),
                        ContributorTypeDesc = c.String(maxLength: 4000),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
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
