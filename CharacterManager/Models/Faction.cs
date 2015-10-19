using System.Collections.Generic;

namespace CharacterManager.Models
{
    public class Faction
    {
        public string Name { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}