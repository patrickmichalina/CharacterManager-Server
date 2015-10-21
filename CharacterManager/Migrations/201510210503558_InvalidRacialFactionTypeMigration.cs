namespace CharacterManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    /// <summary>
    /// Migration
    /// </summary>
    public partial class InvalidRacialFactionTypeMigration : DbMigration
    {
        /// <summary>
        /// Up
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "dbo.InvalidRacialFactions",
                c => new
                    {
                        RaceId = c.String(nullable: false, maxLength: 20),
                        FactionId = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.RaceId, t.FactionId })
                .ForeignKey("dbo.Factions", t => t.FactionId, cascadeDelete: true)
                .ForeignKey("dbo.Races", t => t.RaceId, cascadeDelete: true)
                .Index(t => t.RaceId)
                .Index(t => t.FactionId);
            
        }
        
        /// <summary>
        /// Down
        /// </summary>
        public override void Down()
        {
            DropForeignKey("dbo.InvalidRacialFactions", "RaceId", "dbo.Races");
            DropForeignKey("dbo.InvalidRacialFactions", "FactionId", "dbo.Factions");
            DropIndex("dbo.InvalidRacialFactions", new[] { "FactionId" });
            DropIndex("dbo.InvalidRacialFactions", new[] { "RaceId" });
            DropTable("dbo.InvalidRacialFactions");
        }
    }
}
