
using AutoMapper;
using PooPlanner.Shared.DTO;
using PooPlanner.Domain.Entities;
using PooPlanner.Domain.Repository;

namespace PooPlanner.Shared.Services
{
    internal class FoodService : IFoodService
    {
        private readonly IGenericRepository<Dish> _repository;
        private readonly IMapper _mapper;
        public FoodService(IGenericRepository<Dish> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<FoodDto> GetAll()
        {
            return _mapper.Map<IEnumerable<FoodDto>>(_repository.GetAll());
        }

        public FoodDto GetById(long id)
        {
            return _mapper.Map<FoodDto>(_repository.GetById(id));
        }

        public Dish Create(FoodDto foodDto)
        {
            var dish = _mapper.Map<Dish>(foodDto);
            _repository.Add(dish);
            return dish;
        }

    }
}
