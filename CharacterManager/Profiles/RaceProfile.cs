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
            Mapper.CreateMap<Race, RaceViewModel>()
                .ForMember(dest => dest.Name, cfg => cfg.MapFrom(src => src.Name));
            Mapper.CreateMap<RaceViewModel, Race>()
                .ForMember(dest => dest.Characters, cfg => cfg.Ignore())
                .ForMember(dest => dest.Description, cfg => cfg.Ignore())
                .ForMember(dest => dest.ImageUrl, cfg => cfg.Ignore())
                .ForMember(dest => dest.InvalidRacialClasses, cfg => cfg.Ignore())
                .ForMember(dest => dest.InvalidRacialFactions, cfg => cfg.Ignore())                ;
        }

        /// <summary>
        /// Automapper
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}