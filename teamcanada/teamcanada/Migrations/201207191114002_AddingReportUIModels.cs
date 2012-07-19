namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingReportUIModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Report1UI",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
                        WardNum = c.Int(nullable: false),
                        NumVotes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Report1UI");
        }
    }
}
