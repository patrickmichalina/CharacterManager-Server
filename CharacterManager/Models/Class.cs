using System.Collections.Generic;

namespace CharacterManager.Models
{
    /// <summary>
    /// The type of fighter a character is
    /// </summary>
    public class Class
    {
        /// <summary>
        /// The name of the class
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Characters belonging to this class
        /// </summary>
        public virtual ICollection<Character> Characters { get; set; }

        public virtual ICollection<InvalidRacialClass> InvalidRacialClasses { get; set; }
    }
}