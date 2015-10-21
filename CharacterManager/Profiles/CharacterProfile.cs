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

            Mapper.CreateMap<CharacterViewModel, Character>()
                .ForMember(dest => dest.User, cfg => cfg.Ignore())
                .ForMember(dest => dest.Race, cfg => cfg.Ignore())
                .ForMember(dest => dest.Class, cfg => cfg.Ignore())
                .ForMember(dest => dest.Faction, cfg => cfg.Ignore())
                .ForMember(dest => dest.ClassId, cfg => cfg.MapFrom(src => src.Class))
                .ForMember(dest => dest.FactionId, cfg => cfg.MapFrom(src => src.Faction))
                .ForMember(dest => dest.RaceId, cfg => cfg.MapFrom(src => src.Race));
        }

        /// <summary>
        /// Automapper
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}