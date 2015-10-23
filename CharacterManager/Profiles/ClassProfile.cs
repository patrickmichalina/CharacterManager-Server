using AutoMapper;
using CharacterManager.Models;
using CharacterManager.ViewModels;

namespace CharacterManager.Profiles
{
    /// <summary>
    /// Dto mapping for classes
    /// </summary>
    public class ClassProfile : Profile
    {
        /// <summary>
        /// Configure mapping
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Class, ClassViewModel>();
            Mapper.CreateMap<ClassViewModel, Class>()
                .ForMember(dest => dest.Characters, cfg => cfg.Ignore())
                .ForMember(dest => dest.InvalidRacialClasses, cfg => cfg.Ignore());
        }

        /// <summary>
        /// Automapper
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}