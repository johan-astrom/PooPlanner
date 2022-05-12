using AutoMapper;
using PooPlanner.Domain.UnitsOfWork;
using PooPlanner.Shared.DTO;

namespace PooPlanner.Service.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MedicineService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<MedicineGetDto> GetAllMedicines()
        {
            return _mapper.Map<IEnumerable<MedicineGetDto>>(_uow.MedicineRepository.GetAll());
        }

        public MedicineGetDto GetMedicineById(long id)
        {
            return _mapper.Map<MedicineGetDto>(_uow.MedicineRepository.GetById(id));
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
