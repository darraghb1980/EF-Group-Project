namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class electionresults : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ResultsUIs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        amountElectionType = c.String(),
                        ElectionYear = c.Int(nullable: false),
                        WardNum = c.Int(nullable: false),
                        NumVotes = c.Int(nullable: false),
                        CandidateFirstName = c.String(),
                        CandidateLastName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ResultsUIs");
        }
    }
}
