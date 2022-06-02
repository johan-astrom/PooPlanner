using Newtonsoft.Json;
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

        [JsonProperty(PropertyName = "Medicine")]
        public int MedicineName { get; set; }

        [JsonProperty(PropertyName = "Unit")]
        public string MedicineUnit { get; set; }

        [Display(Name = "Medicine")]
        public MedicineModel SelectedMedicine { get; set; } 
    }

}
