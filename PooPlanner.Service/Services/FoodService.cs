
using AutoMapper;
using PooPlanner.Shared.DTO;
using PooPlanner.Domain.Entities;
using PooPlanner.Domain.Repository;
using PooPlanner.Domain.UnitsOfWork;

namespace PooPlanner.Service.Services
{
    internal class FoodService : IFoodService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public FoodService(IMapper mapper, IUnitOfWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public IEnumerable<FoodGetDto> GetAllDishes()
        {
            return _mapper.Map<IEnumerable<FoodGetDto>>(_uow.DishRepository.GetAll(dish => dish.Allergenes));
        }

        public FoodGetDto GetDishById(long id)
        {
            return _mapper.Map<FoodGetDto>(_uow.DishRepository.GetById(id, dish => dish.Allergenes));
        }

        public FoodGetDto CreateDish(FoodPostDto foodDto)
        {
            var dish = _mapper.Map<Dish>(foodDto);
            _uow.DishRepository.Add(dish);
            _uow.Save();
            return _mapper.Map<FoodGetDto>(dish);
        }

    }
}
