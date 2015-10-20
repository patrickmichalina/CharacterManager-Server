using AutoMapper;
using CharacterManager.Models;
using CharacterManager.ViewModels;

namespace CharacterManager.Profiles
{
    /// <summary>
    /// Dto mapping for characters
    /// </summary>
    public class CharacterProfile : Profile
    {
        /// <summary>
        /// Configure mapping
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Character, CharacterViewModel>()
                .ForMember(dest => dest.Class, cfg => cfg.MapFrom(src => src.Class.Name))
                .ForMember(dest => dest.Faction, cfg => cfg.MapFrom(src => src.Faction.Name))
                .ForMember(dest => dest.Race, cfg => cfg.MapFrom(src => src.Race.Name));
        }

        /// <summary>
        /// Automapper
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}