using System.ComponentModel.DataAnnotations;

namespace PooPlanner.UI.Models
{
    public class MedicationModel
    {
        [Display(Name ="Amount")]
        public int Amount { get; set; }

        [Display(Name ="Date and time")]
        public DateTime Timestamp { get; set; }

        [Display(Name = "Medicine")]
        public int MedicineId { get; set; }

        [Display(Name = "Medicine")]
        public MedicineModel SelectedMedicine { get; set; } 
    }

}
