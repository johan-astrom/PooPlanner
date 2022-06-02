using Newtonsoft.Json;

namespace PooPlanner.UI.Models
{
    public class DishModel
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public List<string> Allergenes { get; set; }
        public DateTime DishTimestamp { get; set; }

        public DishModel()
        {
            Allergenes = new List<string>();
        }
    }
}
