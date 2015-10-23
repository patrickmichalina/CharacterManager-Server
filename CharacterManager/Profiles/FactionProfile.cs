using AutoMapper;
using CharacterManager.Models;
using CharacterManager.ViewModels;

namespace CharacterManager.Profiles
{
    /// <summary>
    /// Dto mapping for factions
    /// </summary>
    public class FactionProfile : Profile
    {
        /// <summary>
        /// Configure mapping
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Faction, FactionViewModel>();
            Mapper.CreateMap<FactionViewModel, Faction>()
                .ForMember(dest => dest.Characters, cfg => cfg.Ignore())
                .ForMember(dest => dest.InvalidRacialFactions, cfg => cfg.Ignore());
        }

        /// <summary>
        /// Automapper
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}