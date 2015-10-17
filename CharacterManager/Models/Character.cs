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
        // getter/setter overrides
        private int _level;
        private string _name;

        /// <summary>
        /// The character's name. Preferably mystical and esoteric.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrEmpty(value)) throw new ArgumentNullException();
                _name = value;
            }
        }

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

        /// <summary>
        /// Level is a representation of how much accumulated experience a character has earned.
        /// </summary>
        public int Level 
        {
            get { return _level; }
            set
            {
                if (value > 90)
                {
                    _level = 90;
                }
                else if (value <= 0)
                {
                    _level = 1;
                }
                else
                {
                    _level = value;
                }
            }
        }

        /// <summary>
        /// Validates model
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            if (Level <= 0 && Level >= 90) return false;
            if (string.IsNullOrEmpty(Name)) return false;
            if (Race == null) return false;
            if (Faction == null) return false;
            if (Class == null) return false;

            return true;
        }
    }
}