using System.Data.Entity;

namespace CharacterManager.Models
{
    /// <summary>
    /// Entity Framework code first mappings of models to sql store
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Character entities in the database
        /// </summary>
        public DbSet<Character> Characters { get; set; }
    }
}