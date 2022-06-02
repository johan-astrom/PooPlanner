

namespace PooPlanner.UI.Models
{
    public class OverviewViewModel
    {
        public List<MedicationModel> Medications { get; set; } = new();

        public List<StoolModel> Stools { get; set; } = new();

        public List<DishModel> Dishes { get; set; } = new();

        //public OverviewViewModel()
        //{
        //    Medications = new List<MedicationModel>();
        //    Stools = new List<StoolModel>();    
        //    Dishes = new List<DishModel>();
        //}
    }
}
