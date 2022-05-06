using PooPlanner.Domain.Entities;
using PooPlanner.Shared.DTO;

namespace PooPlanner.Shared.Services
{
    public interface IFoodService
    {
        FoodGetDto GetById(long id);
        IEnumerable<FoodGetDto> GetAll();
        FoodGetDto Create(FoodPostDto foodDto);
    }
}