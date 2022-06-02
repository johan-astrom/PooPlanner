namespace PooPlanner.UI.Models
{
    public class MedicineModel
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }

        public MedicinalUnit Unit { get; set; }
    }

        public enum MedicinalUnit
        {
            g,
            ml,
            st
        }
  
}
