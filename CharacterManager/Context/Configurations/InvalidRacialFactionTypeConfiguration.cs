using CharacterManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace CharacterManager.Context.Configurations
{
    /// <summary>
    /// Handles the ef-sql database configuration for the Faction Type 
    /// </summary>
    public class InvalidRacialFactionTypeConfiguration : EntityTypeConfiguration<InvalidRacialFaction>
    {
        /// <summary>
        /// Configuration
        /// </summary>
        public InvalidRacialFactionTypeConfiguration()
        {
            HasKey(rc => new { rc.RaceId, rc.FactionId });
            HasRequired(rc => rc.Race).WithMany(@class => @class.InvalidRacialFactions).HasForeignKey(rc => rc.RaceId);
            HasRequired(rc => rc.Faction).WithMany(faction => faction.InvalidRacialFactions).HasForeignKey(rc => rc.FactionId);
        }
    }
}