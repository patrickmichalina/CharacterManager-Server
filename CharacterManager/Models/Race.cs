using System.Collections.Generic;

namespace CharacterManager.Models
{
    /// <summary>
    /// In the World of Warcraft universe there are but two races... Or are there...?
    /// </summary>
    public class Race
    {
        /// <summary>
        /// Name of the race
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Details the charactersistic of the race
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A url pointing to an arbitrary image of the race
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Characters belonging to this race
        /// </summary>
        public virtual ICollection<Character> Characters { get; set; }
    }
}