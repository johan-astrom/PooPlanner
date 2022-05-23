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
    public class MedicationService : IMedicationService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MedicationService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<MedicationPostDto> GetMedicationByTimestamp(DateTime startTime, DateTime endTime)
        {
            return _mapper.Map<IEnumerable<MedicationPostDto>>(_uow.MedicationRepository.GetAll().Where(m => m.TimeStamp >= startTime && m.TimeStamp <= endTime));
        }

        public IEnumerable<MedicationGetDto> GetAllMedications()
        {
            return _mapper.Map<IEnumerable<MedicationGetDto>>(_uow.MedicationRepository.GetAll());
        }
        public MedicationGetDto GetMedicationById(long id)
        {
            return _mapper.Map<MedicationGetDto>(_uow.MedicationRepository.GetById(id));
        }

        public MedicationGetDto CreateMedication(MedicationPostDto medicationDto)
        {
            return _mapper.Map<MedicationGetDto>(_uow.MedicationRepository.Add(_mapper.Map<Medication>(medicationDto)));
        }
    }
}
