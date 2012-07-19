namespace teamcanada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingReportUIModels1 : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Report5UI",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ElectionType = c.String(maxLength: 4000),
                        ElectionYear = c.Int(nullable: false),
                        CandidateFirstName = c.String(maxLength: 4000),
                        CandidateLastName = c.String(maxLength: 4000),
                        ContributionType = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Report5UI");
            DropTable("dbo.Report4UI");
            DropTable("dbo.Report3UI");
            DropTable("dbo.Report2UI");
        }
    }
}
