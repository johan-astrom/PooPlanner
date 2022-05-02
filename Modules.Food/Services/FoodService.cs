using AutoMapper;
using Modules.Food.DTO;
using Modules.Food.Entities;
using Shared.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.Services
{
    internal class FoodService
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
