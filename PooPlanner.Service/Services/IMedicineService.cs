using PooPlanner.Shared.DTO;

namespace PooPlanner.Service.Services
{
    public interface IMedicineService
    {
        IEnumerable<MedicineGetDto> GetAllMedicines();
        MedicineGetDto GetMedicineById(long id);
        MedicineGetDto CreateMedicine(MedicinePostDto postDto);
    }
}