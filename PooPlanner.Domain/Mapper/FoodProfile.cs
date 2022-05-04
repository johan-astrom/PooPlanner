using AutoMapper;
using PooPlanner.Domain.Entities;
using PooPlanner.Shared.DTO;

namespace PooPlanner.Shared.Mapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<Dish, FoodDto>();
        }
    }
}
