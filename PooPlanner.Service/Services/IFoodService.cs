using Modules.Food.DTO;

namespace Modules.Food.Services
{
    internal interface IFoodService
    {
        FoodDto GetById(long id);
    }
}