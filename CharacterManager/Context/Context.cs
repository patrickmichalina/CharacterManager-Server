using System.Data.Entity;

namespace CharacterManager.Models
{
    /// <summary>
    /// Entity Framework code first mappings of models to sql store
    /// </summary>
    public class Context : DbContext
    {
        /// <summary>
        /// Character entities in the database
        /// </summary>
        public virtual DbSet<Character> Characters { get; set; }

        /// <summary>
        /// Class entities in the database
        /// </summary>
        public virtual DbSet<Class> Classes { get; set; }

        /// <summary>
        /// Race entities in the database
        /// </summary>
        public virtual DbSet<Race> Races { get; set; }

        /// <summary>
        /// Faction entities in the database
        /// </summary>
        public virtual DbSet<Faction> Factions { get; set; }
    }
}