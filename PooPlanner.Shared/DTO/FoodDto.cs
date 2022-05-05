namespace PooPlanner.Shared.DTO
{
    public class FoodDto
    {
        public string DishName { get; set; }
        public string? DishSize{ get; set; }
        public List<string>? Allergenes { get; set; }
        public List<string>? Ingredients { get; set; }   
    }
}
