namespace CharacterManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    /// <summary>
    /// Migration
    /// </summary>
    public partial class AddedForeignKeys : DbMigration
    {
        /// <summary>
        /// Upsert
        /// </summary>
        public override void Up()
        {
            RenameColumn(table: "dbo.Characters", name: "Class_Name", newName: "ClassId");
            RenameColumn(table: "dbo.Characters", name: "Faction_Name", newName: "FactionId");
            RenameColumn(table: "dbo.Characters", name: "Race_Name", newName: "RaceId");
            RenameIndex(table: "dbo.Characters", name: "IX_Race_Name", newName: "IX_RaceId");
            RenameIndex(table: "dbo.Characters", name: "IX_Class_Name", newName: "IX_ClassId");
            RenameIndex(table: "dbo.Characters", name: "IX_Faction_Name", newName: "IX_FactionId");
        }
        
        /// <summary>
        /// Down
        /// </summary>
        public override void Down()
        {
            RenameIndex(table: "dbo.Characters", name: "IX_FactionId", newName: "IX_Faction_Name");
            RenameIndex(table: "dbo.Characters", name: "IX_ClassId", newName: "IX_Class_Name");
            RenameIndex(table: "dbo.Characters", name: "IX_RaceId", newName: "IX_Race_Name");
            RenameColumn(table: "dbo.Characters", name: "RaceId", newName: "Race_Name");
            RenameColumn(table: "dbo.Characters", name: "FactionId", newName: "Faction_Name");
            RenameColumn(table: "dbo.Characters", name: "ClassId", newName: "Class_Name");
        }
    }
}
