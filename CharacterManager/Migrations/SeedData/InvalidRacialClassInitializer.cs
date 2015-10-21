using CharacterManager.Models;
using System;
using System.Collections.Generic;

namespace CharacterManager.Migrations.SeedData
{
    /// <summary>
    /// Maps prohibited race/class combos
    /// </summary>
    public static class InvalidRacialClassInitializer
    {
        /// <summary>
        /// Defines the list of prohibited race/class combos
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<InvalidRacialClass> CreateInvalidRacialClassInitializer()
        {
            try
            {
                return new List<InvalidRacialClass>
                {
                    new InvalidRacialClass { ClassId = "Warrior", RaceId = "Blood Elf" },
                    new InvalidRacialClass { ClassId = "Druid", RaceId = "Orc" },
                    new InvalidRacialClass { ClassId = "Druid", RaceId = "Blood Elf" },
                    new InvalidRacialClass { ClassId = "Druid", RaceId = "Human" },
                    new InvalidRacialClass { ClassId = "Druid", RaceId = "Gnome" }
                };
            }

            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}