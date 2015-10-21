using static CharacterManager.Migrations.SeedData.RaceInitializer;
using static CharacterManager.Migrations.SeedData.FactionInitializer;
using static CharacterManager.Migrations.SeedData.ClassInitializer;
using static CharacterManager.Migrations.SeedData.CharacterInitializer;
using static CharacterManager.Migrations.SeedData.InvalidRacialClassInitializer;
using System.Data.Entity.Migrations;
using CharacterManager.Models;

namespace CharacterManager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Models.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationContext context)
        {
            // insert basic data
            foreach (var race in CreateRaces())
            {
                context.Races.AddOrUpdate(race);
            }

            // create factions
            foreach (var faction in CreateFactions())
            {
                context.Factions.AddOrUpdate(faction);
            }

            // create list of classes
            foreach (var _class in CreateClasses())
            {
                context.Classes.AddOrUpdate(_class);
            }

            // create list of prohibited race/class combinations
            foreach (var _invalidRacialClass in CreateInvalidRacialClassInitializer())
            {
                context.InvalidRacialClasses.AddOrUpdate(_invalidRacialClass);
            }

            // create demo characters
            foreach (var character in CreateCharacters(context))
            {
                context.Characters.AddOrUpdate(c => c.Name, character);
            }

            // persist to database
            context.SaveChanges();
        }
    }
}
