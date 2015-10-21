using CharacterManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace CharacterManager.Context.Configurations
{
    /// <summary>
    /// Handles the ef-sql database configuration for the Faction Type 
    /// </summary>
    public class ValidRacialClassTypeConfiguration : EntityTypeConfiguration<ValidRacialClass>
    {
        /// <summary>
        /// Configuration
        /// </summary>
        public ValidRacialClassTypeConfiguration()
        {
            HasKey(rc => new { rc.ClassId, rc.RaceId });
            HasRequired(rc => rc.Class).WithMany(@class => @class.ValidRacialClasses).HasForeignKey(rc => rc.ClassId);
            HasRequired(rc => rc.Race).WithMany(@class => @class.ValidRacialClasses).HasForeignKey(rc => rc.RaceId);
        }
    }
}