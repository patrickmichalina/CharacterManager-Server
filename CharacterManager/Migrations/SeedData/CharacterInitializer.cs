using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterManager.Migrations.SeedData
{
    /// <summary>
    /// Handles initial set of racial data
    /// </summary>
    public static class CharacterInitializer
    {
        /// <summary>
        /// Creates a list of races in the game
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Character> CreateCharacters(ApplicationContext context)
        {
            try
            {
                return new List<Character>
                {
                    new Character
                    {
                        Name = "Azeroth",
                        ClassId = "Mage",
                        FactionId = "Alliance",
                        RaceId = "Human",
                        Level = 1,
                        IsDeleted = false
                    },
                    new Character
                    {
                        Name = "Aragorn",
                        ClassId = "Mage",
                        FactionId = "Horde",
                        RaceId = "Orc",
                        Level = 89,
                        IsDeleted = true
                    }
                };
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}