using CharacterManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace CharacterManager.Context.Configurations
{
    /// <summary>
    /// Handles the ef-sql database configuration for the Character Type 
    /// </summary>
    public class CharacterTypeConfiguration : EntityTypeConfiguration<Character>
    {
        /// <summary>
        /// Configuration
        /// </summary>
        public CharacterTypeConfiguration()
        {
            HasKey(character => character.Name);
            Property(character => character.Name).HasMaxLength(15).IsRequired();
            Property(character => character.Level).IsRequired();
            HasRequired(character => character.Race);
            HasRequired(character => character.Faction);
            HasRequired(character => character.Class);
        }
    }
}