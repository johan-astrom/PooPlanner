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
            CreateMap<Allergene, string>().ConvertUsing(a => a.Name);
            CreateMap<Medicine, MedicineGetDto>();
            CreateMap<MedicinePostDto, Medicine>();

            CreateMap<Medication, MedicationGetDto>().ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.Medicine.Unit));
            CreateMap<MedicationPostDto, Medication>();
        }
    }
}
