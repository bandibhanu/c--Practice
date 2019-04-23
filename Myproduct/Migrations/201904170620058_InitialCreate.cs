namespace Myproduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Myproductclasses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        name = c.String(nullable: false, maxLength: 50),
                        category = c.String(),
                        Orderdate = c.DateTime(nullable: false),
                        productquality = c.Int(nullable: false),
                        productprise = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Myproductclasses");
        }
    }
}
