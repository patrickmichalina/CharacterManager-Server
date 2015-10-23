using System.ComponentModel.DataAnnotations;

namespace CharacterManager.ViewModels
{
    /// <summary>
    /// Race dto
    /// </summary>
    public class RaceViewModel
    {
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}