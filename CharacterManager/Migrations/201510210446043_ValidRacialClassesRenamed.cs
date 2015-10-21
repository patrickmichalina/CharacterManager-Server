namespace CharacterManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    /// <summary>
    /// Migration
    /// </summary>
    public partial class ValidRacialClassesRenamed : DbMigration
    {
        /// <summary>
        /// Up
        /// </summary>
        public override void Up()
        {
            RenameTable(name: "dbo.ValidRacialClasses", newName: "InvalidRacialClasses");
        }
        
        /// <summary>
        /// Up
        /// </summary>
        public override void Down()
        {
            RenameTable(name: "dbo.InvalidRacialClasses", newName: "ValidRacialClasses");
        }
    }
}
