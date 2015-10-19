using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace CharacterManager.Controllers
{
    /// <summary>
    /// Character API
    /// </summary>
    public class CharactersController : ApiController
    {
        /// <summary>
        /// Get a list of all Characters
        /// </summary>
        /// <returns></returns>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(IEnumerable<Character>))]
        public async Task<IHttpActionResult> Get(string name = null)
        {
            if(!string.IsNullOrEmpty(name))
            {
                throw new NotImplementedException();
            } else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Delete a Character
        /// </summary>
        /// <returns></returns>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Character))]
        public async Task<IHttpActionResult> Delete(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a Character
        /// </summary>
        /// <returns></returns>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Character))]
        public async Task<IHttpActionResult> Post(Character character)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a Character
        /// </summary>
        /// <returns></returns>
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
        /// <returns></returns>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Character))]
        public async Task<IHttpActionResult> Patch(string name, Character character)
        {
            throw new NotImplementedException();
        }
    }
}