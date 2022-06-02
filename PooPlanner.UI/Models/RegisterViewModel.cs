namespace PooPlanner.UI.Models
{
    public class RegisterViewModel
    {
        public MedicationModel Medication { get; set; } = new();
        public MedicineModel Medicine { get; set; }
        public StoolModel Stool { get; set; }
        public DishModel Dish { get; set; }
        public List<MedicineModel> Medicines { get; set; }

    }
}
