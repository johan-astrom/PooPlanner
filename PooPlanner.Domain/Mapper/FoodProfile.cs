using AutoMapper;
using PooPlanner.Domain.Entities;
using PooPlanner.Shared.DTO;

namespace PooPlanner.Domain.Mapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<FoodPostDto, Dish>();
            CreateMap<Dish, FoodGetDto>();
            CreateMap<string, Allergene>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src));
            CreateMap<Allergene, string>().ForMember(dest => dest, opt => opt.MapFrom(src => src.Name));

            CreateMap<Medicine, MedicineGetDto>();
            CreateMap<Medication, MedicationDto>();
        }
    }
}
