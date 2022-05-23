using AutoMapper;
using PooPlanner.Domain.Entities;
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

        public MedicineGetDto CreateMedicine(MedicinePostDto postDto)
        {
            var medicine = _mapper.Map<Medicine>(postDto);
            var createdMedicine = _uow.MedicineRepository.Add(medicine);
            _uow.Save();
            return _mapper.Map<MedicineGetDto>(createdMedicine);
        }

    }
}
