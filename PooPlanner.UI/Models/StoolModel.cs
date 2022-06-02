using System.ComponentModel.DataAnnotations;

namespace PooPlanner.UI.Models
{
    public class StoolModel
    {
        public DateTime Timestamp { get; set; }
        [Display(Name = "Stool size")]
        public StoolSize Size { get; set; }
        public StoolConsistency Consistency { get; set; }
    }
    public enum StoolConsistency
    {
        Runny,
        Soft,
        Normal,
        Hard
    }
    public enum StoolSize
    {
        Small,
        Normal,
        Large
    }
}
