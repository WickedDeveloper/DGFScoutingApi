namespace DGFScouting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recruits",
                c => new
                    {
                        RecruitId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Position = c.String(),
                        Rating = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.RecruitId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recruits");
        }
    }
}
