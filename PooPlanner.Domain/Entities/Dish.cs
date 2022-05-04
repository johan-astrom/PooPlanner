using System.ComponentModel.DataAnnotations;

namespace PooPlanner.Domain.Entities
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
