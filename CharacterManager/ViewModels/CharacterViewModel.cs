using System.ComponentModel.DataAnnotations;

namespace CharacterManager.ViewModels
{
    /// <summary>
    /// Character dto
    /// </summary>
    public class CharacterViewModel
    {
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        /// <summary>
        /// Race
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string Race { get; set; }

        /// <summary>
        /// Class
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string Class { get; set; }

        /// <summary>
        /// Faction
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string Faction { get; set; }

        /// <summary>
        /// Logical delete allows for deleting/undeleting of characters.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Level is a representation of how much accumulated experience a character has earned.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Validates model
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            if (Level <= 0 && Level >= 90) return false;
            if (string.IsNullOrEmpty(Name)) return false;
            if (string.IsNullOrEmpty(Race)) return false;
            if (string.IsNullOrEmpty(Faction)) return false;
            if (string.IsNullOrEmpty(Class)) return false;

            return true;
        }
    }
}