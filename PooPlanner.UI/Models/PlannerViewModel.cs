using Newtonsoft.Json;

namespace PooPlanner.UI.Models
{
    public class PlannerViewModel
    {
        [JsonProperty("Timestamp")]
        public DateTime StoolTimestamp { get; set; }
        public string StoolSize { get; set; }
        public string StoolConsistency { get; set; }
        public int MedicationAmount { get; set; }
        public DateTime MedicationTimestamp { get; set; }
        public string MedicineName { get; set; }
        public string MedicationUnit { get; set; }
        public string DishName { get; set; }
        public string DishSize { get; set; }
        [JsonProperty("Allergenes")]
        public List<string> DishAllergenes { get; set; }

        public PlannerViewModel()
        {
            DishAllergenes = new List<string>();
        }
    }
}
