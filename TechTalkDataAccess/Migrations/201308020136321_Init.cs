namespace TechTalkDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TechTalks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastModificationDateTime = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TechTalks");
        }
    }
}
