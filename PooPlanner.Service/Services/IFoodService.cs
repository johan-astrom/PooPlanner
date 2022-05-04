using PooPlanner.Shared.DTO;

namespace PooPlanner.Shared.Services
{
    public interface IFoodService
    {
        FoodDto GetById(long id);
    }
}