namespace CharacterManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        /// <summary>
        /// Initial upsert
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 15),
                        IsDeleted = c.Boolean(nullable: false),
                        Level = c.Int(nullable: false),
                        Class_Name = c.String(nullable: false, maxLength: 20),
                        Faction_Name = c.String(nullable: false, maxLength: 20),
                        Race_Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Classes", t => t.Class_Name, cascadeDelete: true)
                .ForeignKey("dbo.Factions", t => t.Faction_Name, cascadeDelete: true)
                .ForeignKey("dbo.Races", t => t.Race_Name, cascadeDelete: true)
                .Index(t => t.Class_Name)
                .Index(t => t.Faction_Name)
                .Index(t => t.Race_Name);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Factions",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 20),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        /// <summary>
        /// Initial Down
        /// </summary>
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "Race_Name", "dbo.Races");
            DropForeignKey("dbo.Characters", "Faction_Name", "dbo.Factions");
            DropForeignKey("dbo.Characters", "Class_Name", "dbo.Classes");
            DropIndex("dbo.Characters", new[] { "Race_Name" });
            DropIndex("dbo.Characters", new[] { "Faction_Name" });
            DropIndex("dbo.Characters", new[] { "Class_Name" });
            DropTable("dbo.Races");
            DropTable("dbo.Factions");
            DropTable("dbo.Classes");
            DropTable("dbo.Characters");
        }
    }
}
