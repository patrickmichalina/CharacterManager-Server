using CharacterManager.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CharacterManager.ViewModels;

namespace CharacterManager.Controllers
{
    /// <summary>
    /// Faction API
    /// </summary>
    public class FactionsController : ApiController
    {
        private readonly Repository _repository = new Repository();

        /// <summary>
        /// Get a list of all Races
        /// </summary>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(IEnumerable<FactionViewModel>))]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_repository.GetFactions());
            }
            catch
            {
                return InternalServerError();
            }
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