using CharacterManager.Context.Configurations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TrackerEnabledDbContext.Identity;

namespace CharacterManager.Models
{
    /// <summary>
    /// Entity Framework code first mappings of models to sql store
    /// </summary>
    public class ApplicationContext : TrackerIdentityContext<IdentityUser>
    {
        /// <summary>
        /// Constructor for our application database
        /// </summary>
        public ApplicationContext() : base("name=CharacterManagerContext") { }
        
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

        /// <summary>
        /// Invalid racial class entities in the database
        /// </summary>
        public virtual DbSet<InvalidRacialClass> InvalidRacialClasses { get; set; }

        /// <summary>
        /// Invalid racial factions entities in the database
        /// </summary>
        public virtual DbSet<InvalidRacialFaction> InvalidRacialFactions { get; set; }

        /// <summary>
        /// Construct the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CharacterTypeConfiguration());
            modelBuilder.Configurations.Add(new ClassTypeConfiguration());
            modelBuilder.Configurations.Add(new FactionTypeConfiguration());
            modelBuilder.Configurations.Add(new RaceTypeConfiguration());
            modelBuilder.Configurations.Add(new InvalidRacialClassTypeConfiguration());
            modelBuilder.Configurations.Add(new InvalidRacialFactionTypeConfiguration());
        }
    }
}