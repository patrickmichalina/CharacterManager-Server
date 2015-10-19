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
            HasRequired(character => character.Race).WithMany(race => race.Characters).HasForeignKey(character => character.RaceId);
            HasRequired(character => character.Faction).WithMany(faction => faction.Characters).HasForeignKey(character => character.FactionId);
            HasRequired(character => character.Class).WithMany(@class => @class.Characters).HasForeignKey(character => character.ClassId);
        }
    }
}