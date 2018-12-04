namespace DGFScouting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recruits", "AddedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recruits", "AddedAt");
        }
    }
}
