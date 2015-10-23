using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CharacterManager.ViewModels;

namespace CharacterManager.Controllers
{
    /// <summary>
    /// Character API
    /// </summary>
    public class CharactersController : ApiController
    {
        private readonly Repository _repository = new Repository();

        /// <summary>
        /// Get a list of all Characters
        /// </summary>
        /// <param name="name">The character's name</param>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(IEnumerable<CharacterViewModel>))]
        public IHttpActionResult Get(string name = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var _character = _repository.GetCharacter(name);

                    if (_character == null) return NotFound();

                    return Ok(_character);
                }
                else
                {
                    return Ok(_repository.GetCharacters());
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
        public IHttpActionResult Delete(string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest("Must supply an id");

            var _saveOperationResult = _repository.DeleteCharacter(name);

            if (_saveOperationResult == 0) return NotFound();

            return Ok();
        }

        /// <summary>
        /// Create a Character
        /// </summary>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(CharacterViewModel))]
        public async Task<IHttpActionResult> Post(CharacterViewModel characterViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Make sure the model is valid");

            var result = _repository.CreateCharacter(characterViewModel);

            if (result != Repository.CharacterCreationStatusCode.Created) return BadRequest(Enum.GetName(typeof(Repository.CharacterCreationStatusCode), result));

            return Ok(result);
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

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}