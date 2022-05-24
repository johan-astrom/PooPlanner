using AutoMapper;
using PooPlanner.Domain.Entities;
using PooPlanner.Domain.UnitsOfWork;
using PooPlanner.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Service.Services
{
    public class StoolService : IStoolService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public StoolService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<StoolGetDto> GetAllStools()
        {
            return _mapper.Map<IEnumerable<StoolGetDto>>(_uow.StoolRepository.GetAll());
        }

        public StoolGetDto GetStoolById(long id)
        {
            return _mapper.Map<StoolGetDto>(_uow.StoolRepository.GetById(id));
        }

        public IEnumerable<StoolGetDto> GetStoolByTimestamp(DateTime startTime, DateTime endTime)
        {
            return _mapper.Map<IEnumerable<StoolGetDto>>(_uow.StoolRepository.GetAll().Where(s => s.Timestamp >= startTime && s.Timestamp <= endTime));
        }

        public StoolGetDto CreateStool(StoolPostDto postDto)
        {
            var stool = _mapper.Map<Stool>(postDto);
            _uow.StoolRepository.Add(stool);
            _uow.Save();
            return _mapper.Map<StoolGetDto>(stool);
        }
    }
}
