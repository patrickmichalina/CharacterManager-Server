using AutoMapper;
using CharacterManager.Models;
using CharacterManager.ViewModels;

namespace CharacterManager.Profiles
{
    /// <summary>
    /// Dto mapping for races
    /// </summary>
    public class RaceProfile : Profile
    {
        /// <summary>
        /// Configure mapping
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Race, RaceViewModel>();
            Mapper.CreateMap<RaceViewModel, Race>();
        }

        /// <summary>
        /// Automapper
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}