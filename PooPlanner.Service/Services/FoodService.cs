
using AutoMapper;
using PooPlanner.Shared.DTO;
using PooPlanner.Domain.Entities;
using PooPlanner.Domain.Repository;
using PooPlanner.Domain.UnitsOfWork;

namespace PooPlanner.Shared.Services
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

        public IEnumerable<FoodGetDto> GetAll()
        {
            return _mapper.Map<IEnumerable<FoodGetDto>>(_uow.DishRepository.GetAll());
        }

        public FoodGetDto GetById(long id)
        {
            return _mapper.Map<FoodGetDto>(_uow.DishRepository.GetById(id));
        }

        public FoodGetDto Create(FoodPostDto foodDto)
        {
            var dish = _mapper.Map<Dish>(foodDto);
            _uow.DishRepository.Add(dish);
            _uow.Save();
            return _mapper.Map<FoodGetDto>(dish);
        }

    }
}
