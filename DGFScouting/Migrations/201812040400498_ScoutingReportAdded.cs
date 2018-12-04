namespace DGFScouting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScoutingReportAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScoutingReports",
                c => new
                    {
                        ScoutingReportId = c.Int(nullable: false, identity: true),
                        Skills = c.Int(nullable: false),
                        TeamPlay = c.Int(nullable: false),
                        Fitness = c.Int(nullable: false),
                        Character = c.Int(nullable: false),
                        Notes = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        Recruit_RecruitId = c.Int(),
                    })
                .PrimaryKey(t => t.ScoutingReportId)
                .ForeignKey("dbo.Recruits", t => t.Recruit_RecruitId)
                .Index(t => t.Recruit_RecruitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScoutingReports", "Recruit_RecruitId", "dbo.Recruits");
            DropIndex("dbo.ScoutingReports", new[] { "Recruit_RecruitId" });
            DropTable("dbo.ScoutingReports");
        }
    }
}
