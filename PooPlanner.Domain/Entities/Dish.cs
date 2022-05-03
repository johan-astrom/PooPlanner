using Modules.Food.Entities;
using Shared.DataAccess;
using Shared.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.Entities
{
    public class Dish : EntityBase
    {

        [Required]
        public string Name { get; set; }
        public DishSize DishSize { get; set; }
        public List<Allergene> Allergenes { get; set; }

        public Dish()
        {
            Allergenes = new List<Allergene>();
        }
    }

    public enum DishSize
    {
        Small,
        Medium,
        Large,
    }
}
