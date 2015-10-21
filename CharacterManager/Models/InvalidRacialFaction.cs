namespace CharacterManager.Models
{
    /// <summary>
    /// Race / Faction combinations that are invalid
    /// </summary>
    public class InvalidRacialFaction
    {
        public virtual Race Race { get; set; }

        public string RaceId { get; set; }

        public virtual Faction Faction { get; set; }

        public string FactionId { get; set; }
    }
}