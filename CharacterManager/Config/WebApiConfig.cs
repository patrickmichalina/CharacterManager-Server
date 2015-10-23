using AutoMapper;
using CharacterManager.Profiles;
using System.Web.Http;

namespace CharacterManager
{
    /// <summary>
    /// Core API configuration area
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registration
        /// </summary>
        /// <param name="Config"></param>
        public static void Register(HttpConfiguration Config)
        {
            // using default routing naming conventions
            Config.Routes.MapHttpRoute("DefaultRoute", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            // Configure Automapper
            Mapper.Initialize(cfg => {
                cfg.AddProfile<CharacterProfile>();
                cfg.AddProfile<RaceProfile>();
                cfg.AddProfile<ClassProfile>();
                cfg.AddProfile<FactionProfile>();
            });

            Mapper.AssertConfigurationIsValid();
        }
    }
}