using static CharacterManager.Migrations.SeedData.RaceInitializer;
using static CharacterManager.Migrations.SeedData.FactionInitializer;
using static CharacterManager.Migrations.SeedData.ClassInitializer;
using static CharacterManager.Migrations.SeedData.CharacterInitializer;

using System.Data.Entity.Migrations;
using System.Linq;
using System.Collections;
using CharacterManager.Models;
using System;
using System.Data.Entity;

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

            foreach (var faction in CreateFactions())
            {
                context.Factions.AddOrUpdate(faction);
            }

            foreach (var _class in CreateClasses())
            {
                context.Classes.AddOrUpdate(_class);
            }

            foreach (var character in CreateCharacters(context))
            {
                context.Characters.AddOrUpdate(c => c.Name, character);
                
            }

            context.SaveChanges();
        }
    }
}
