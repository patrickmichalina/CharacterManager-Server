using CharacterManager.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CharacterManager.ViewModels;

namespace CharacterManager.Controllers
{
    /// <summary>
    /// Character API
    /// </summary>
    public class RacesController : ApiController
    {
        private readonly Repository _repository = new Repository();

        /// <summary>
        /// Get a list of all Races
        /// </summary>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(IEnumerable<RaceViewModel>))]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_repository.GetRaces());
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