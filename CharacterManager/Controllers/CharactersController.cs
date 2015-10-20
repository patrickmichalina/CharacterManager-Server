using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using CharacterManager.ViewModels;

namespace CharacterManager.Controllers
{
    /// <summary>
    /// Character API
    /// </summary>
    public class CharactersController : ApiController
    {
        private readonly ApplicationContext _context = new ApplicationContext();

        /// <summary>
        /// Get a list of all Characters
        /// </summary>
        /// <param name="name">The character's name</param>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(IEnumerable<Character>))]
        public IHttpActionResult Get(string name = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var _character = _context.Characters.SingleOrDefault(character => character.Name == name);

                    if (_character == null) return NotFound();

                    return Ok(Mapper.Map<CharacterViewModel>(_character));
                }
                else
                {
                    return Ok(Mapper.Map<IEnumerable<CharacterViewModel>>(_context.Characters));
                }
            }
            catch
            {
                return InternalServerError();
            }
        }

        /// <summary>
        /// Delete a Character
        /// </summary>
        /// <param name="name">The character's name</param>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Character))]
        public async Task<IHttpActionResult> Delete(string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest("Must supply an id");

            var _character = _context.Characters.SingleOrDefault(character => character.Name == name);

            if (_character == null) return NotFound();

            _context.Characters.Remove(_character);

            await _context.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Create a Character
        /// </summary>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Character))]
        public async Task<IHttpActionResult> Post(Character character)
        {
            if (!ModelState.IsValid) return BadRequest("Make sure the model is valid");


            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a Character
        /// </summary>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Character))]
        public async Task<IHttpActionResult> Put(Character character)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a Character (delta request)
        /// </summary>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Character))]
        public async Task<IHttpActionResult> Patch(string name, Character character)
        {
            throw new NotImplementedException();
        }
    }
}