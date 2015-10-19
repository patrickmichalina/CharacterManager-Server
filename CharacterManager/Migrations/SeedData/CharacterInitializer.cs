using CharacterManager.Models;
using System;
using System.Collections.Generic;

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
                    },
                    new Character
                    {
                        Name = "Falcor",
                        ClassId = "Warrior",
                        FactionId = "Alliance",
                        RaceId = "Human",
                        Level = 50,
                        IsDeleted = false
                    },
                    new Character
                    {
                        Name = "Fanboy",
                        ClassId = "Mage",
                        FactionId = "Horde",
                        RaceId = "Blood Elf",
                        Level = 89,
                        IsDeleted = false
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