using CharacterManager.Models;
using System;
using System.Collections.Generic;

namespace CharacterManager.Migrations.SeedData
{
    /// <summary>
    /// Handles initial set of racial data
    /// </summary>
    public static class RaceInitializer
    {
        /// <summary>
        /// Creates a list of races in the game
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Race> CreateRaces()
        {
            try
            {
                return new List<Race>
                {
                    new Race { Name = "Orc", Description = "Unlike the other races of the Horde, orcs are not native to Azeroth. Initially, they lived as shamanic clans on the lush world of Draenor. They abandoned their peaceful culture when Kil’jaeden, a demon lord of the Burning Legion, corrupted the orcs and used them in his vengeful plot against the draenei, who were exiles from Kil’jaeden’s homeworld." },
                    new Race { Name = "Tauren", Description = "The peaceful tauren—known in their own tongue as the shu’halo—have long dwelled in Kalimdor, striving to preserve the balance of nature at the behest of their goddess, the Earth Mother. Until recently, the tauren lived as nomads scattered throughout the Barrens, hunting the great kodo beasts native to the arid region." },
                    new Race { Name = "Blood Elf", Description = "For nearly 7,000 years, high elven society centered on the sacred Sunwell, a magical fount that was created using a vial of pure arcane energy from the first Well of Eternity. Nourished and strengthened by the Sunwell’s potent energies, the high elves’ enchanted kingdom of Quel’Thalas prospered within the verdant forests north of Lordaeron." },
                    new Race { Name = "Human", Description = "Recent discoveries have shown that humans are descended from the barbaric vrykul, half-giant warriors who live in Northrend. Early humans were primarily a scattered and tribal people for several millennia, until the rising strength of the troll empire forced their strategic unification. Thus the nation of Arathor was formed, along with its capital, the city-state of Strom." },
                    new Race { Name = "Gnome", Description = "The clever, spunky, and oftentimes eccentric gnomes present a unique paradox among the civilized races of Azeroth. Brilliant inventors with an irrepressibly cheerful disposition, this race has suffered treachery, displacement, and near-genocide. It is their remarkable optimism in the face of such calamity that symbolizes the truly unshakable spirit of the gnomes." },
                    new Race { Name = "Worgen", Description = "Behind the formidable Greymane Wall, a terrible curse has spread throughout the isolated human nation of Gilneas, transforming many of its stalwart citizens into nightmarish beasts known as worgen. The origins of this curse have been fiercely debated, but only recently has the startling truth come to light." }
                };
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}