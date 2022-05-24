namespace PooPlanner.Shared.DTO
{
    public class FoodGetDto
    {
        public long Id { get; set; }
        public string DishName { get; set; }
        public string DishSize{ get; set; }
        public List<string> Allergenes { get; set; } 
    }
    public class FoodPostDto
    {
        public string DishName { get; set; }
        public int DishSize { get; set; }
        public List<string> Allergenes { get; set; }
    }
}
