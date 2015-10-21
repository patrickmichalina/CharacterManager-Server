namespace CharacterManager.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Migration
    /// </summary>
    public partial class ValidRacialClasses : DbMigration
    {
        /// <summary>
        /// Up
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "dbo.ValidRacialClasses",
                c => new
                    {
                        ClassId = c.String(nullable: false, maxLength: 20),
                        RaceId = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.ClassId, t.RaceId })
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Races", t => t.RaceId, cascadeDelete: true)
                .Index(t => t.ClassId)
                .Index(t => t.RaceId);
            
        }
        
        /// <summary>
        /// Down
        /// </summary>
        public override void Down()
        {
            DropForeignKey("dbo.ValidRacialClasses", "RaceId", "dbo.Races");
            DropForeignKey("dbo.ValidRacialClasses", "ClassId", "dbo.Classes");
            DropIndex("dbo.ValidRacialClasses", new[] { "RaceId" });
            DropIndex("dbo.ValidRacialClasses", new[] { "ClassId" });
            DropTable("dbo.ValidRacialClasses");
        }
    }
}
