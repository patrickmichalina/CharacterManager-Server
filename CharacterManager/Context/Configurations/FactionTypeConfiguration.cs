using CharacterManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace CharacterManager.Context.Configurations
{
    /// <summary>
    /// Handles the ef-sql database configuration for the Faction Type 
    /// </summary>
    public class FactionTypeConfiguration : EntityTypeConfiguration<Faction>
    {
        /// <summary>
        /// Configuration
        /// </summary>
        public FactionTypeConfiguration()
        {
            HasKey(faction => faction.Name);
            Property(faction => faction.Name).IsRequired().HasMaxLength(20);
            HasMany(faction => faction.Characters);
        }
    }
}