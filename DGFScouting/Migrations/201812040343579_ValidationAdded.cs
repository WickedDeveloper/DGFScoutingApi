namespace DGFScouting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Recruits", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Recruits", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Recruits", "Position", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Recruits", "Notes", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Recruits", "Notes", c => c.String());
            AlterColumn("dbo.Recruits", "Position", c => c.String());
            AlterColumn("dbo.Recruits", "LastName", c => c.String());
            AlterColumn("dbo.Recruits", "FirstName", c => c.String());
        }
    }
}
