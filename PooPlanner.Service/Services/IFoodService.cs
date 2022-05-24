using PooPlanner.Domain.Entities;
using PooPlanner.Shared.DTO;

namespace PooPlanner.Service.Services
{
    public interface IFoodService
    {
        FoodGetDto GetDishById(long id);
        IEnumerable<FoodGetDto> GetAllDishes();
        FoodGetDto CreateDish(FoodPostDto foodDto);
    }
}