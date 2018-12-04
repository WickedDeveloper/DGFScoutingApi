namespace DGFScouting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommittedPlayerAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommittedPlayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        JerseyNumber = c.Int(nullable: false),
                        CommitmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CommittedPlayers");
        }
    }
}
