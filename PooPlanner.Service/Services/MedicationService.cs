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

        public IEnumerable<MedicationGetDto> GetMedicationByTimestamp(DateTime startTime, DateTime endTime)
        {
            return _mapper.Map<IEnumerable<MedicationGetDto>>(_uow.MedicationRepository.GetAll().Where(m => m.TimeStamp >= startTime && m.TimeStamp <= endTime));
        }

        public IEnumerable<MedicationGetDto> GetAllMedications()
        {
            return _mapper.Map<IEnumerable<MedicationGetDto>>(_uow.MedicationRepository.GetAll(m => m.Medicine));
        }
        public MedicationGetDto GetMedicationById(long id)
        {
            return _mapper.Map<MedicationGetDto>(_uow.MedicationRepository.GetById(id, m => m.Medicine));
        }

        public MedicationGetDto CreateMedication(MedicationPostDto medicationDto)
        {
            var medication = _mapper.Map<Medication>(medicationDto);
            var medicine = _uow.MedicineRepository.GetById(medicationDto.MedicineId);
            medication.Medicine = medicine;
            _uow.MedicationRepository.Add(medication);
            _uow.Save();
            return _mapper.Map<MedicationGetDto>(medication);
        }
    }
}
