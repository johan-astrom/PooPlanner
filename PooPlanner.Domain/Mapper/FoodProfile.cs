using AutoMapper;
using Modules.Food.DTO;
using Modules.Food.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.Mapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<Dish, FoodDto>();
        }
    }
}
