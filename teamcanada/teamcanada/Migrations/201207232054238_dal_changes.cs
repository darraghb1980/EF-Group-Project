namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dal_changes : DbMigration
    {
        public override void Up()
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
            
            DropTable("dbo.Report1UI");
            DropTable("dbo.Report2UI");
            DropTable("dbo.Report3UI");
            DropTable("dbo.Report4UI");
            DropTable("dbo.Report5UI");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Report5UI",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
                        ContributionTypeDesc = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Report4UI",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
                        Wardnum = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Report3UI",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        Wardnum = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Report2UI",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
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
            
            DropTable("dbo.ReportsUIs");
        }
    }
}
