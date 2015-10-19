namespace CharacterManager.Migrations
{
    using System.Data.Entity.Migrations;
    
    /// <summary>
    /// Migration
    /// </summary>
    public partial class AddedUserToCharacter : DbMigration
    {
        /// <summary>
        /// Up
        /// </summary>
        public override void Up()
        {
            AddColumn("dbo.Characters", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Characters", "User_Id");
            AddForeignKey("dbo.Characters", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        /// <summary>
        /// Down
        /// </summary>
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Characters", new[] { "User_Id" });
            DropColumn("dbo.Characters", "User_Id");
        }
    }
}
