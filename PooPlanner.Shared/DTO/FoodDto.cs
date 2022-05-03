using Modules.Food.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.DTO
{
    internal class FoodDto
    {
        public string? DishName { get; set; }
        public string? DishSize{ get; set; }
        public List<string>? Allergenes { get; set; }
    }
}
