using CharacterManager.Models;
using System;
using System.Collections.Generic;

namespace CharacterManager.Migrations.SeedData
{
    /// <summary>
    /// Handles initial set of class data
    /// </summary>
    public static class ClassInitializer
    {
        /// <summary>
        /// Creates a list of classes in the game
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Class> CreateClasses()
        {
            try
            {
                return new List<Class>
                {
                    new Class { Name = "Warrior" },
                    new Class { Name = "Druid" },
                    new Class { Name = "Death Knight" },
                    new Class { Name = "Mage" }
                };
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}