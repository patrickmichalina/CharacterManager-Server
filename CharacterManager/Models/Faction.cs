using System.Collections.Generic;

namespace CharacterManager.Models
{
    /// <summary>
    /// A group of races who fight alongside each other
    /// </summary>
    public class Faction
    {
        /// <summary>
        /// The name of the faction
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Characters in the faction
        /// </summary>
        public virtual ICollection<Character> Characters { get; set; }

        public virtual ICollection<InvalidRacialFaction> InvalidRacialFactions { get; set; }
    }
}