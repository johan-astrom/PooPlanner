using AutoMapper;
using PooPlanner.Domain.Entities;
using PooPlanner.Shared.DTO;

namespace PooPlanner.Domain.Mapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<FoodDto, Dish>();
            CreateMap<string, Allergene>();
            CreateMap<string, DishSize>();
        }
    }
}
