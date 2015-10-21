using CharacterManager.Models;
using System;
using System.Collections.Generic;

namespace CharacterManager.Migrations.SeedData
{
    /// <summary>
    /// Maps prohibited race/class combos
    /// </summary>
    public static class InvalidRacialFactionInitializer
    {
        /// <summary>
        /// Defines the list of prohibited race/class combos
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<InvalidRacialFaction> CreateInvalidRacialFactionInitializer()
        {
            try
            {
                return new List<InvalidRacialFaction>
                {
                    new InvalidRacialFaction { FactionId = "Horde", RaceId = "Human" },
                    new InvalidRacialFaction { FactionId = "Horde", RaceId = "Gnome" },
                    new InvalidRacialFaction { FactionId = "Horde", RaceId = "Worgen" },
                    new InvalidRacialFaction { FactionId = "Alliance", RaceId = "Orc" },
                    new InvalidRacialFaction { FactionId = "Alliance", RaceId = "Tauren" },
                    new InvalidRacialFaction { FactionId = "Alliance", RaceId = "Blood Elf" }
                };
            }
            
            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}