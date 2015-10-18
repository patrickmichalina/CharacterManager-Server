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

        }
    }
}