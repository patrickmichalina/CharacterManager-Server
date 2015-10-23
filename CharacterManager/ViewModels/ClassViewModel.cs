using System.ComponentModel.DataAnnotations;

namespace CharacterManager.ViewModels
{
    /// <summary>
    /// Class dto
    /// </summary>
    public class ClassViewModel
    {
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}