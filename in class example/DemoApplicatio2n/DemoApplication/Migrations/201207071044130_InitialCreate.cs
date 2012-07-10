namespace DemoApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExchangeRates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fromCurrency = c.String(),
                        toCurrency = c.String(),
                        rate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ExchangeUIs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        amount = c.Double(nullable: false),
                        fromCurrency = c.String(),
                        toCurrency = c.String(),
                        comments = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExchangeUIs");
            DropTable("dbo.ExchangeRates");
        }
    }
}
