using CharacterManager.Models;
using System;
using System.Collections.Generic;

namespace CharacterManager.Migrations.SeedData
{
    /// <summary>
    /// Handles initial set of faction data
    /// </summary>
    public static class FactionInitializer
    {
        /// <summary>
        /// Creates a list of factions in the game
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Faction> CreateFactions()
        {
            try
            {
                return new List<Faction>
                {
                    new Faction { Name = "Horder" },
                    new Faction { Name = "Alliance" }
                };
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}