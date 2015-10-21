using CharacterManager.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterManager.Models
{
    /// <summary>
    /// Interaction with the database.
    /// </summary>
    public class Repository
    {
        private readonly ApplicationContext _context = new ApplicationContext();
        private readonly string Username = HttpContext.Current.User.Identity.Name;

        /// <summary>
        /// List of codes returned when trying to create a new character
        /// </summary>
        public enum CharacterCreationStatusCode
        {
            /// <summary>
            /// Congratulations!
            /// </summary>
            Created,

            /// <summary>
            /// Level was out of range
            /// </summary>
            LevelOutOfBound,

            /// <summary>
            /// Faction is not valid
            /// </summary>
            FactionDoesNotExist,

            /// <summary>
            /// Race is not valid
            /// </summary>
            RaceDoesNotExist,

            /// <summary>
            /// Class is not valid
            /// </summary>
            ClassDoesNotExist,

            /// <summary>
            /// The user name is already chosen
            /// </summary>
            AlreadyExists,

            /// <summary>
            /// The selected race and faction were not compatible
            /// </summary>
            InvalidRaceFactionMapping,

            /// <summary>
            /// The selected race and class were not compatible
            /// </summary>
            InvalidRaceClassMapping,

            /// <summary>
            /// User doesn't have a high enough character to start a new one
            /// </summary>
            UserLevelRequirementsNotMet,

            /// <summary>
            /// Not yet defined model error
            /// </summary>
            UncaughtModelError
        }

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

            return _context.SaveChanges(Username);
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

            return _context.SaveChanges(Username);
        }

        /// <summary>
        /// Attempts to create a new character from the client input
        /// </summary>
        /// <param name="characterViewModel"></param>
        /// <returns></returns>
        public CharacterCreationStatusCode CreateCharacter(CharacterViewModel characterViewModel)
        {
            var character = AutoMapper.Mapper.Map<Character>(characterViewModel);

            var statusCode = CanCreateCharacter(character);

            if (statusCode == CharacterCreationStatusCode.Created)
            {
                _context.Characters.Add(character);
                _context.SaveChanges(Username);
            }

            return statusCode;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool CanBeCreateKnight(string user)
        {
            return _context.Characters.Where(character => character.User.UserName == user).Any(s => s.Level > 55);
        }

        private bool IsCharacterNameAlreadyTaken(string name)
        {
            return _context.Characters.Any(character => character.Name == name);
        }

        private bool SelectedClassExists(string name)
        {
            var results = _context.Classes.SingleOrDefault(c => c.Name == name);

            return results != null ? true : false;
        }

        private bool SelectedRaceExists(string name)
        {
            var results = _context.Races.SingleOrDefault(c => c.Name == name);

            return results != null ? true : false;
        }

        private bool SelectedFactionExists(string name)
        {
            var results = _context.Factions.SingleOrDefault(c => c.Name == name);

            return results != null ? true : false;
        }

        /// <summary>
        /// Checks if a new character has valid settings
        /// </summary>
        /// <param name="character">The potential character</param>
        /// <returns></returns>
        private CharacterCreationStatusCode CanCreateCharacter(Character character)
        {
            if (!SelectedClassExists(character.ClassId)) return CharacterCreationStatusCode.ClassDoesNotExist;

            if (!SelectedRaceExists(character.RaceId)) return CharacterCreationStatusCode.RaceDoesNotExist;

            if (!SelectedFactionExists(character.FactionId)) return CharacterCreationStatusCode.FactionDoesNotExist;

            if (!character.LevelIsValid()) return CharacterCreationStatusCode.LevelOutOfBound;

            if (!character.IsValid()) return CharacterCreationStatusCode.UncaughtModelError;

            if (!CanBeClass(character.RaceId, character.ClassId)) return CharacterCreationStatusCode.InvalidRaceClassMapping;

            if (!CanJoinFaction(character.RaceId, character.FactionId)) return CharacterCreationStatusCode.InvalidRaceFactionMapping;

            if (IsCharacterNameAlreadyTaken(character.Name)) return CharacterCreationStatusCode.AlreadyExists;

            if (character.ClassId == "Death Knight")
            {
                if (!CanBeCreateKnight(Username)) return CharacterCreationStatusCode.UserLevelRequirementsNotMet;
            }

            return CharacterCreationStatusCode.Created;
        }
    }
}