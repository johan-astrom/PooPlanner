using AutoMapper;
using PooPlanner.Domain.UnitsOfWork;
using PooPlanner.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Service.Services
{
    internal class MedicationService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;

        public MedicationService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<MedicationDto> GetMedicationByTimestamp(DateTime startTime, DateTime endTime)
        {
            return _mapper.Map<IEnumerable<MedicationDto>>(_uow.MedicationRepository.GetAll().Where(m => m.TimeStamp >= startTime && m.TimeStamp <= endTime));
        }

        public IEnumerable<MedicationDto> GetAllMedications()
        {
            return _mapper.Map<IEnumerable<MedicationDto>>(_uow.MedicationRepository.GetAll());
        }
        public MedicationDto GetMedicationById(long id)
        {
            return _mapper.Map<MedicationDto>(_uow.MedicationRepository.GetById(id));
        }
    }
}
