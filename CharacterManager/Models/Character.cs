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
        /// In the World of Warcraft universe there are but two races... Or are there...?
        /// </summary>
        public virtual Race Race { get; set; }

        /// <summary>
        /// The character class represents the scope of their skills and abilities. Think Mage, Warlock, and Panda Bear Wrestlers.
        /// </summary>
        public virtual Class Class { get;set; }
    }
}