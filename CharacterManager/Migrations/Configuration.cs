using static CharacterManager.Migrations.SeedData.RaceInitializer;
using static CharacterManager.Migrations.SeedData.FactionInitializer;

using System.Data.Entity.Migrations;
using System.Linq;
using System.Collections;
using CharacterManager.Models;
using System;
using System.Data.Entity;

namespace CharacterManager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.Context context)
        {
            // insert basic data
            foreach(var race in CreateRaces())
            {
                context.Races.AddOrUpdate(r => r.Name, race);
            }

            foreach (var faction in CreateFactions())
            {
                context.Factions.AddOrUpdate(f => f.Name, faction);
            }

            context.SaveChanges();
        }
    }
}
