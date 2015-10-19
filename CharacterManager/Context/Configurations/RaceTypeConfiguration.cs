using CharacterManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace CharacterManager.Context.Configurations
{
    /// <summary>
    /// Handles the ef-sql database configuration for the Faction Type 
    /// </summary>
    public class RaceTypeConfiguration : EntityTypeConfiguration<Race>
    {
        /// <summary>
        /// Configuration
        /// </summary>
        public RaceTypeConfiguration()
        {
            HasKey(race => race.Name);
            Property(race => race.Name).IsRequired().HasMaxLength(20);
        }
    }
}