# World of Warcraft Character Manager API
Web services for the management of a World of Warcraft player’s characters.

## Hosting
These [demo web services](https://character-manager.azurewebsites.net) are hosted on Microsoft Azure under the Web App platform. Simple swagger documentation can be found [here](https://character-manager.azurewebsites.net/swagger).

## Security
There isn't any. Thrash it.

## Integration
Whatever is commited to the master branch gets deployed. Any tests in the solution also get ran before deployment.

## Character Properties
1. Name
2. Level (1 – 90)
3. Race (Orc, Tauren, Blood Elf, Human, Gnome, Worgen)
4. Class (Warrior, Druid, Death Knight, Mage)
5. Faction (Horde, Alliance)

## Constraints
1. Orc, Tauren, and Blood Elf races are exclusively Horde.
2. Human, Gnome, and Worgen races are exclusively Alliance.
3. Only Taurens and Worgen can be Druids.
4. Blood Elves cannot be Warriors.
5. Death Knights are created at level 55, but the player must have at least one active level 55 character.
6. A player should be able to delete and undelete characters.
