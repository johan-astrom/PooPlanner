using AutoMapper;
using PooPlanner.Domain.UnitsOfWork;
using PooPlanner.Shared.DTO;

namespace PooPlanner.Service.Services
{
    public class MedicineService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MedicineService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<MedicineGetDto> GetAll()
        {
            return _mapper.Map<IEnumerable<MedicineGetDto>>(_uow.MedicineRepository.GetAll());
        }

        public MedicineGetDto GetById(long id)
        {
            return _mapper.Map<MedicineGetDto>(_uow.MedicineRepository.GetById(id));
        }
    }
}
