namespace DGFScouting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateScoutingReport : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ScoutingReports", "Notes", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ScoutingReports", "Notes", c => c.String());
        }
    }
}
