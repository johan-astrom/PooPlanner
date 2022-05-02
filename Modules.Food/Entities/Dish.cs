using Shared.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.Core.Entities
{
    public class Dish : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public DishSize DishSize { get; set; }
        public List<String> Allergenes { get; set; }

        public Dish(string name, DishSize dishSize)
        {
            Name = name;
            DishSize = dishSize;
            Allergenes = new List<string>();
        }
    }

    public enum DishSize
    {
        Small,
        Medium,
        Large,
    }
}
