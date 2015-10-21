using CharacterManager.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CharacterManager.Models
{
    /// <summary>
    /// Interaction with the database.
    /// </summary>
    public class Repository
    {
        private readonly ApplicationContext _context = new ApplicationContext();

        /// <summary>
        /// Gets a character from the database and converts it to a view-model for the client
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public CharacterViewModel GetCharacter(string name)
        {
            return AutoMapper.Mapper.Map<CharacterViewModel>(_context.Characters.Single(character => character.Name == name));
        }

        /// <summary>
        /// Gets a;; characters from the database and converts them to a view-model for the client
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CharacterViewModel> GetCharacters()
        {
            return AutoMapper.Mapper.Map<IEnumerable<CharacterViewModel>>(_context.Characters);
        }
        
        /// <summary>
        /// Delete a character from the database - this is actually only a logical delete (record remains in db)
        /// </summary>
        /// <param name="name"></param>
        public int DeleteCharacter(string name)
        {
            var _character = _context.Characters.SingleOrDefault(character => character.Name == name);

            if (_character == null) return 0;

            _character.IsDeleted = true;

            return _context.SaveChanges();
        }

        /// <summary>
        /// Restore a character (change delete flag) from the database.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int RestoreCharacter(string name)
        {
            var _character = _context.Characters.SingleOrDefault(character => character.Name == name);

            if (_character == null) return 0;

            _character.IsDeleted = false;

            return _context.SaveChanges();
        }

        /// <summary>
        /// Checks to see if the new character has a valid race/faction mapping
        /// </summary>
        /// <param name="race">Race of the potential character</param>
        /// <param name="faction">Faction of the potential character</param>
        /// <returns></returns>
        private bool CanJoinFaction(string race, string faction)
        {
            return !_context.InvalidRacialFactions.Any(rf => rf.FactionId == faction && rf.RaceId == race);
        }

        /// <summary>
        /// Checks to see if the new character has a valid race/class mapping
        /// </summary>
        /// <param name="race"></param>
        /// <param name="_class"></param>
        /// <returns></returns>
        private bool CanBeClass(string race, string _class)
        {
            return !_context.InvalidRacialClasses.Any(rf => rf.ClassId == _class && rf.RaceId == race);
        }
    }
}