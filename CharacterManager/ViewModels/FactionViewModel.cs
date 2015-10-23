using System.ComponentModel.DataAnnotations;

namespace CharacterManager.ViewModels
{
    /// <summary>
    /// Faction dto
    /// </summary>
    public class FactionViewModel
    {
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}