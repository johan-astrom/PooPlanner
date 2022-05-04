
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

        public FoodDto GetById(long id)
        {
            return _mapper.Map<FoodDto>(_repository.GetById(id));
        }

    }
}
