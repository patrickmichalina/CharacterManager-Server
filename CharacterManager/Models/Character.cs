using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterManager.Models
{
    /// <summary>
    /// A World of Warcraft game character. 
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The character's name. Preferably mystical and esoteric.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A character's race is the most tangible and real aspect to their being.
        /// This is unchangeable and dictates almost all aspects of what choices they cant make.
        /// </summary>
        public virtual Race Race { get; set; }

        /// <summary>
        /// The character class represents the scope of their skills and abilities. Think Mage, Warlock, and Panda Bear Wrestlers.
        /// </summary>
        public virtual Class Class { get;set; }

        /// <summary>
        /// A loosely related group of races joined in fighting toward mutually beneficials goals of varying degrees.
        /// </summary>
        public virtual Faction Faction { get; set; }

        /// <summary>
        /// Logical delete allows for deleting/undeleting of characters.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}